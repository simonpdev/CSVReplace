# CSVReplace
A C# Windows Forms App which takes two input .CSV files:
- A base file
- An update file
  
And automatically detects changes between the contents of rows within the base and update files to then apply them to the former

---

### Input Format:
- Base .CSV File
- Updates/Changes .CSV File
- Index of Primary Key position within row (value should be the same in both .CSV files in order to correctly identify rows)

### Output Format:
-  Merged .CSV file containing all changes applied from the update file to the base one
