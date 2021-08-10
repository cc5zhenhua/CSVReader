
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


    public class Foo
    {
        public string images;
        public string product_handle;
        public string state;
        public string rating;
        public string title;
        public string author;
        public string email;
        public string location;
        public string body;
        public string reply;
        public string created_at;
        public string replied_at;
    }
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
