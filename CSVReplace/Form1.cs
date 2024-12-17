using System.Diagnostics;

namespace CSVReplace
{
    public partial class frmBase : Form
    {
        public string BaseFilePath = "";
        public string ChangesFilePath = "";

        public int CSVKeyIndex = 0;
        public Dictionary<string, int> CSVKeysIndexes = new Dictionary<string, int>();

        public List<string> BaseDB = new List<string>();
        public List<string> ChangesDB = new List<string>();


        public enum Tabs
        {
            BASE,
            OUTPUT,
            LOG
        };

        public frmBase()
        {
            InitializeComponent();
        }




        // --- MISC FUNCTIONS ---
        public void Log(string text)
        {
            rtbLog.Text += text + Environment.NewLine;
        }




        // --- ERROR CONDITIONS CHECK ---
        public string ComputeErrorMessage(bool[] conditions, string[] messages)
        {
            string message = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    try
                    {
                        message += messages[i] + "\n";
                    }
                    catch
                    {
                        message += $"ERROR for condition {i}" + "\n";
                    }
                }
            }

            return message;
        }

        public bool CanReplaceValues()
        {
            bool[] errorConditions = {
                String.IsNullOrEmpty(BaseFilePath),
                String.IsNullOrEmpty(ChangesFilePath)
            };

            string[] errorMessages = {
                "Base File was not selected",
                "Changes File was not selected"
            };

            string errorMessage = ComputeErrorMessage(errorConditions, errorMessages);

            if (String.IsNullOrEmpty(errorMessage)) return true;
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            }
        }




        // --- FILE SELECTION FUNCTIONS ---
        public void BaseFileSelect()
        {
            if (openDBDialog.ShowDialog() == DialogResult.OK && openDBDialog.FileName != "")
            {
                BaseFilePath = openDBDialog.FileName;
                this.Text = openDBDialog.FileName + " - CSV Replace";

                txtBaseFilepath.Text = openDBDialog.FileName;
                txtBaseFilepath.Select(openDBDialog.FileName.Length, 0);
                txtBaseFilepath.ScrollToCaret();

                ReadBaseFile();
                rtbBaseFile.Lines = BaseDB.ToArray();
                tabContent.SelectedIndex = 0;
            }
            openDBDialog.FileName = "";
        }

        public void ChangesFileSelect()
        {
            if (openDBDialog.ShowDialog() == DialogResult.OK && openDBDialog.FileName != "")
            {
                ChangesFilePath = openDBDialog.FileName;

                txtChangesFilepath.Text = openDBDialog.FileName;
                txtChangesFilepath.Select(openDBDialog.FileName.Length, 0);
                txtChangesFilepath.ScrollToCaret();
            }
            openDBDialog.FileName = "";
        }




        // --- FILE READ FUNCTIONS ---
        public List<string> ReadBaseFile()
        {
            List<string> log = new List<string>();
            BaseDB.Clear();
            CSVKeysIndexes.Clear();

            using StreamReader baseFileReader = new StreamReader(BaseFilePath);
            int currentRowIndex = 0;
            while (!baseFileReader.EndOfStream)
            {
                string currentRow = baseFileReader.ReadLine() ?? "";

                if(!String.IsNullOrWhiteSpace(currentRow))
                {
                    string current_key = RowReadValueAt(currentRow, CSVKeyIndex);
                    CSVKeysIndexes[current_key] = currentRowIndex;
                }

                BaseDB.Add(currentRow);
                currentRowIndex++;
            }
            baseFileReader.Close();

            return log;
        }

        public List<string> ReadChangesFile()
        {
            ChangesDB.Clear();
            List<string> log = new List<string>();

            using StreamReader changesFileReader = new StreamReader(ChangesFilePath);
            int currentRowIndex = 0;
            while (!changesFileReader.EndOfStream)
            {
                string currentRow = changesFileReader.ReadLine() ?? "";

                if (!String.IsNullOrEmpty(currentRow))
                {
                    List<string> rowValues = RowReadAllValues(currentRow);
                    if (!String.IsNullOrEmpty(rowValues[CSVKeyIndex]))
                    {
                        if (CSVKeysIndexes.ContainsKey(rowValues[CSVKeyIndex]))
                        {
                            Log($"Line {CSVKeysIndexes[rowValues[CSVKeyIndex]]}: {BaseDB[CSVKeysIndexes[rowValues[CSVKeyIndex]]]} -> {currentRow}");
                            BaseDB[CSVKeysIndexes[rowValues[CSVKeyIndex]]] = currentRow;
                        }
                        else
                        {
                            BaseDB.Add(currentRow);
                            Log(Environment.NewLine + $"> ADDED AT LINE {BaseDB.Count - 1}" + Environment.NewLine);
                        }
                    }
                    else Log(Environment.NewLine + $"> KEY AT LINE {currentRowIndex} OF REPLACEMENT FILE IS EMPTY!!!" + Environment.NewLine);
                }

                currentRowIndex++;
            }
            changesFileReader.Close();

            return log;
        }

        public void ReloadKeys()
        {
            CSVKeysIndexes.Clear();
            int lineIndex = 0;

            foreach (string line in BaseDB)
            {
                string current_key = RowReadValueAt(line, CSVKeyIndex);
                CSVKeysIndexes[current_key] = lineIndex;
                lineIndex++;
            }
        }




        // --- ROW FUNCTIONS ---
        public string RowReadValueAt(string text, int index = 0)
        {
            string value = "";
            int currentValueIndex = 0;
            bool ignoreNextComma = false;
            bool isAtTargetIndex = currentValueIndex == index;

            foreach (char c in text)
            {
                if (c != ',' || ignoreNextComma)
                {
                    if (c == '"') ignoreNextComma = !ignoreNextComma;
                    if (isAtTargetIndex) value += c;
                }
                else
                {
                    currentValueIndex++;
                    if (currentValueIndex > index) break;
                    isAtTargetIndex = currentValueIndex == index;
                }
            }
            return value;
        }

        public List<string> RowReadAllValues(string text)
        {
            List<string> values = new List<string>();
            string currentValue = "";
            bool ignoreNextComma = false;
            foreach (char c in text)
            {
                if (c != ',' || ignoreNextComma)
                {
                    if (c == '"') ignoreNextComma = !ignoreNextComma;
                    currentValue += c;
                }
                else
                {
                    values.Add(currentValue);
                    currentValue = "";
                }
            }

            values.Add(currentValue);
            return values;
        }

        public void ReplaceValues()
        {
            if (CSVKeyIndex != (int)numKeyIndex.Value)
            {
                CSVKeyIndex = (int)numKeyIndex.Value;
                ReloadKeys();
            }

            if (saveDBDialog.ShowDialog() == DialogResult.OK && saveDBDialog.FileName != "")
            {
                try
                {
                    rtbLog.Text = "";
                    ReadChangesFile();

                    File.WriteAllLines(saveDBDialog.FileName, BaseDB);
                    rtbOutput.Lines = BaseDB.ToArray();
                    tabContent.SelectedIndex = (int)Tabs.LOG;
                }
                catch (Exception e)
                {
                    switch (e)
                    {
                        case ArgumentOutOfRangeException:
                            MessageBox.Show("Value of Key Index is out of range", "Key index out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }




        // --- FORM CONTROLS EVENTS ---
        private void txtBaseFilepath_TextChanged(object sender, EventArgs e)
        {
            txtBaseFilepath.Select(txtBaseFilepath.Text.Length, 0);
        }

        private void txtChangesFilepath_TextChanged(object sender, EventArgs e)
        {
            txtChangesFilepath.Select(txtChangesFilepath.Text.Length, 0);
        }


        // --- BUTTON CLICK EVENTS ---
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if(CanReplaceValues())
            {
                ReplaceValues();
            }
        }

        private void btnLoadBaseFile_Click(object sender, EventArgs e)
        {
            BaseFileSelect();
        }

        private void btnLoadChangesFile_Click(object sender, EventArgs e)
        {
            ChangesFileSelect();
        }
    }
}