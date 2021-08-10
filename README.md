# CSVReader

Copy from "https://www.codeproject.com/Articles/9258/A-Fast-CSV-Reader" 

This version is for .netcore platform  
Nuget package  https://www.nuget.org/packages/CSVReader2/1.0.0

## It can be used for csv contains "," "\n" " special characters

## Simple Demo
    using (CsvReader csv = new CsvReader(new StreamReader(@"test.csv", true), true))
            {
                int fieldCount = csv.FieldCount;
                string[] headers = csv.GetFieldHeaders();
                Console.WriteLine(string.Join(",", headers));
                while (csv.ReadNextRecord())
                {
                    string[] lineData = new string[fieldCount];
                    csv.CopyCurrentRecordTo(lineData);
                    Console.WriteLine(string.Join(",", lineData));
                }
            }
