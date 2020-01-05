namespace SortedNameApplication
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;
    using SortedNameApplication.Class;
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Assessment Programming code");
                Console.WriteLine("Step 1: Reading File -> unsorted-names-list.txt");
                Console.WriteLine("Containing the following list of unsorted names: ");
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string[] lines = File.ReadAllLines(path + "\\unsorted-names-list.txt");// File.ReadAllLines(  @"c:\textfile.txt");
                var TempName = new List<NameList>();

                foreach (string line in lines)
                {
                    string[] testTem = line.Split(' ');
                    int y = 0;
                    string Fname = string.Empty;
                    //string Lname = string.Empty;
                    if (testTem.Length > 1)
                    {
                        do
                        {
                            Fname += testTem[y] + " ";
                            y++;
                        }
                        while (y < testTem.Length - 1);
                    }
                    else
                    {
                        Fname = testTem.First();
                    }


                    TempName.Add(new NameList(Fname, testTem.Last()));
                }


                NameList[] unsort = TempName.ToArray();
                for (int i = 0; i < unsort.Length; i++)
                {
                    Console.WriteLine(string.Format("{1} {0}", unsort[i].firstName, unsort[i].lastName));
                }
                NameList[] sorted = TempName.OrderBy(x => x.lastName).ThenBy(x => x.firstName).ToArray();

                Console.WriteLine("\n");
                Console.WriteLine("The Result List of Sorted Name:\n");
                WriteLog SaveLog = new WriteLog();

                for (int i = 0; i < sorted.Length; i++)
                {
                    string Fprint = string.Format("{1} {0}", sorted[i].firstName, sorted[i].lastName);
                    SaveLog.SaveLog(path + "\\sorted-names-list.txt", Fprint);
                    Console.WriteLine(Fprint);
                }
                Console.WriteLine("Done.\n");
                Console.WriteLine("Press any key go to exit.\n");
                Console.ReadKey();
            }
            catch (Exception exception2)
            {
                Console.WriteLine(exception2.Message);
                Console.WriteLine("Press any key go to exit.\n");
                Console.ReadKey();
            }
        }
    }
}
