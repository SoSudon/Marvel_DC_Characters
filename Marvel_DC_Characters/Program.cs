using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Marvel_DC_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " === Marvel_DC_Characters === ";

            Console.WriteLine(@"
                          __  __                      _            _____   _____ 
                         |  \/  |                    | |   ___    |  __ \ / ____|
                         | \  / | __ _ _ ____   _____| |  ( _ )   | |  | | |     
                         | |\/| |/ _` | '__\ \ / / _ \ |  / _ \/\ | |  | | |     
                         | |  | | (_| | |   \ V /  __/ | | (_>  < | |__| | |____ 
                         |_|  |_|\__,_|_|    \_/ \___|_|  \___/\/ |_____/ \_____|                                                  
                                                  
                       ");

            //Request Input From User
            Console.WriteLine(" Select one of the following for find character ");
            Console.WriteLine();
            Console.WriteLine("\t 1    Marvel");
            Console.WriteLine("\t 2    DC");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Title = " === Marvel_DC_Characters === ";
                Console.Clear();
                Console.WriteLine(" There is 00 Good Characters and 00 Bad Characters ");
                Console.WriteLine();
                Console.WriteLine(" Select G for Super Heroes or B for Bad One ");
                Console.WriteLine();
                Console.ReadLine();
            }


            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "heroes_information_marvel_dc.csv");
            var fileContents = ReadHeroesResults(fileName);
        }
            public static string ReadFile(string fileName)
            {
                using (var reader = new StreamReader(fileName))
                {
                    return reader.ReadToEnd();
                }
            }

            public static List<string[]> ReadHeroesResults(string fileName)
            {
                var heroesResults = new List<string[]>();
                using (var reader = new StreamReader(fileName))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        heroesResults.Add(values);
                    }
                }
                return heroesResults;
            }

        }
    }


    

