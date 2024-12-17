namespace CSVReplace
{
    partial class frmBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openDBDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadChangesFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numKeyIndex = new System.Windows.Forms.NumericUpDown();
            this.btnLoadBaseFile = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.rtbBaseFile = new System.Windows.Forms.TextBox();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.rtbOutput = new System.Windows.Forms.TextBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.TextBox();
            this.saveDBDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtChangesFilepath = new System.Windows.Forms.TextBox();
            this.lblChangesFilepath = new System.Windows.Forms.Label();
            this.txtBaseFilepath = new System.Windows.Forms.TextBox();
            this.lblBaseFile = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyIndex)).BeginInit();
            this.tabBase.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDBDialog
            // 
            this.openDBDialog.Filter = "File CSV|*.csv";
            this.openDBDialog.InitialDirectory = "Desktop";
            // 
            // btnLoadChangesFile
            // 
            this.btnLoadChangesFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadChangesFile.Location = new System.Drawing.Point(495, 350);
            this.btnLoadChangesFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadChangesFile.Name = "btnLoadChangesFile";
            this.btnLoadChangesFile.Size = new System.Drawing.Size(272, 34);
            this.btnLoadChangesFile.TabIndex = 1;
            this.btnLoadChangesFile.Text = "SET CHANGES FILE PATH";
            this.btnLoadChangesFile.UseVisualStyleBackColor = true;
            this.btnLoadChangesFile.Click += new System.EventHandler(this.btnLoadChangesFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key Index";
            // 
            // numKeyIndex
            // 
            this.numKeyIndex.Location = new System.Drawing.Point(17, 44);
            this.numKeyIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numKeyIndex.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numKeyIndex.Name = "numKeyIndex";
            this.numKeyIndex.Size = new System.Drawing.Size(100, 23);
            this.numKeyIndex.TabIndex = 2;
            this.numKeyIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoadBaseFile
            // 
            this.btnLoadBaseFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadBaseFile.Location = new System.Drawing.Point(495, 312);
            this.btnLoadBaseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadBaseFile.Name = "btnLoadBaseFile";
            this.btnLoadBaseFile.Size = new System.Drawing.Size(272, 34);
            this.btnLoadBaseFile.TabIndex = 0;
            this.btnLoadBaseFile.Text = "LOAD BASE FILE";
            this.btnLoadBaseFile.UseVisualStyleBackColor = true;
            this.btnLoadBaseFile.Click += new System.EventHandler(this.btnLoadBaseFile_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReplace.Location = new System.Drawing.Point(495, 388);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(272, 34);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tabBase
            // 
            this.tabBase.BackColor = System.Drawing.SystemColors.Control;
            this.tabBase.Controls.Add(this.rtbBaseFile);
            this.tabBase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabBase.ForeColor = System.Drawing.Color.Black;
            this.tabBase.Location = new System.Drawing.Point(4, 24);
            this.tabBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBase.Name = "tabBase";
            this.tabBase.Size = new System.Drawing.Size(450, 404);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = " Base";
            // 
            // rtbBaseFile
            // 
            this.rtbBaseFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbBaseFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBaseFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbBaseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbBaseFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbBaseFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbBaseFile.Location = new System.Drawing.Point(0, 0);
            this.rtbBaseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbBaseFile.Multiline = true;
            this.rtbBaseFile.Name = "rtbBaseFile";
            this.rtbBaseFile.ReadOnly = true;
            this.rtbBaseFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rtbBaseFile.Size = new System.Drawing.Size(450, 404);
            this.rtbBaseFile.TabIndex = 1;
            this.rtbBaseFile.WordWrap = false;
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.tabBase);
            this.tabContent.Controls.Add(this.tabOutput);
            this.tabContent.Controls.Add(this.tabLog);
            this.tabContent.Location = new System.Drawing.Point(15, 9);
            this.tabContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(458, 432);
            this.tabContent.TabIndex = 4;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.rtbOutput);
            this.tabOutput.Location = new System.Drawing.Point(4, 24);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Size = new System.Drawing.Size(450, 404);
            this.tabOutput.TabIndex = 3;
            this.tabOutput.Text = "Output";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbOutput.Location = new System.Drawing.Point(0, 0);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOutput.Multiline = true;
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rtbOutput.Size = new System.Drawing.Size(450, 404);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.WordWrap = false;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtbLog);
            this.tabLog.Location = new System.Drawing.Point(4, 24);
            this.tabLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(450, 404);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbLog.Multiline = true;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rtbLog.Size = new System.Drawing.Size(450, 404);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.WordWrap = false;
            // 
            // saveDBDialog
            // 
            this.saveDBDialog.Filter = "File CSV|*.csv";
            this.saveDBDialog.InitialDirectory = "Desktop";
            // 
            // txtChangesFilepath
            // 
            this.txtChangesFilepath.BackColor = System.Drawing.SystemColors.Window;
            this.txtChangesFilepath.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtChangesFilepath.Location = new System.Drawing.Point(17, 100);
            this.txtChangesFilepath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChangesFilepath.Name = "txtChangesFilepath";
            this.txtChangesFilepath.ReadOnly = true;
            this.txtChangesFilepath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtChangesFilepath.Size = new System.Drawing.Size(233, 23);
            this.txtChangesFilepath.TabIndex = 1;
            this.txtChangesFilepath.TabStop = false;
            this.txtChangesFilepath.TextChanged += new System.EventHandler(this.txtChangesFilepath_TextChanged);
            // 
            // lblChangesFilepath
            // 
            this.lblChangesFilepath.AutoSize = true;
            this.lblChangesFilepath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChangesFilepath.Location = new System.Drawing.Point(17, 83);
            this.lblChangesFilepath.Name = "lblChangesFilepath";
            this.lblChangesFilepath.Size = new System.Drawing.Size(74, 15);
            this.lblChangesFilepath.TabIndex = 10;
            this.lblChangesFilepath.Text = "Changes File";
            // 
            // txtBaseFilepath
            // 
            this.txtBaseFilepath.BackColor = System.Drawing.SystemColors.Window;
            this.txtBaseFilepath.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBaseFilepath.Location = new System.Drawing.Point(17, 45);
            this.txtBaseFilepath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaseFilepath.Name = "txtBaseFilepath";
            this.txtBaseFilepath.ReadOnly = true;
            this.txtBaseFilepath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBaseFilepath.Size = new System.Drawing.Size(233, 23);
            this.txtBaseFilepath.TabIndex = 0;
            this.txtBaseFilepath.TabStop = false;
            this.txtBaseFilepath.TextChanged += new System.EventHandler(this.txtBaseFilepath_TextChanged);
            // 
            // lblBaseFile
            // 
            this.lblBaseFile.AutoSize = true;
            this.lblBaseFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBaseFile.Location = new System.Drawing.Point(17, 28);
            this.lblBaseFile.Name = "lblBaseFile";
            this.lblBaseFile.Size = new System.Drawing.Size(52, 15);
            this.lblBaseFile.TabIndex = 8;
            this.lblBaseFile.Text = "Base File";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBaseFilepath);
            this.groupBox1.Controls.Add(this.txtChangesFilepath);
            this.groupBox1.Controls.Add(this.lblBaseFile);
            this.groupBox1.Controls.Add(this.lblChangesFilepath);
            this.groupBox1.Location = new System.Drawing.Point(495, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numKeyIndex);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(495, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnLoadChangesFile);
            this.Controls.Add(this.btnLoadBaseFile);
            this.Controls.Add(this.tabContent);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CSV Replace";
            ((System.ComponentModel.ISupportInitialize)(this.numKeyIndex)).EndInit();
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabContent.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tabOutput.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openDBDialog;
        private Button btnReplace;
        private TabPage tabBase;
        private TabControl tabContent;
        private TabPage tabLog;
        private Button btnLoadBaseFile;
        private Label label1;
        private NumericUpDown numKeyIndex;
        private Button btnLoadChangesFile;
        private TextBox rtbBaseFile;
        private SaveFileDialog saveDBDialog;
        private TextBox rtbLog;
        private TabPage tabOutput;
        private TextBox rtbOutput;
        private TextBox txtChangesFilepath;
        private Label lblChangesFilepath;
        private TextBox txtBaseFilepath;
        private Label lblBaseFile;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}