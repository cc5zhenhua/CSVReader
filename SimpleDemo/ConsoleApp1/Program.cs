
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
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

            Console.WriteLine("Hello World!");
        }
    }
}
