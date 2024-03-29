﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = File.Open("C:/Users/LENOVO/Desktop/excele/101102.xlsx", FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            
                             //reader.GetDouble(0);
                            Console.Write(reader.GetString(0)+"  ");
                            Console.Write(reader.GetString(1) + "  ");
                            Console.Write(reader.GetValue(4) + "  ");
                            Console.Write(reader.GetString(5) + "  ");
                            Console.Write(reader.GetValue(8) + "  ");
                            Console.Write(reader.GetString(11) + "  ");
                            Console.Write(reader.GetString(12) + "  ");
                            Console.Write(reader.GetString(16) + "  ");
                            Console.Write("\n");
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    // var result = reader.AsDataSet();

                    // The result of each spreadsheet is in result.Tables
                    Console.ReadKey();
                }
            }
            /*
            Nuget ExcelDataReader-darmowe na licencji MIT reader czyta wierszami i można wziąć wartości z poszczegolnych kolumn automatycznie przechodzi przez wszystkie arkusze.
            Excel package is next to test
            */
        }
    }
}
