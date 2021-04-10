using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;



namespace Marvel_DC_Characters
{
    class Program
    {      
        static void Main(string[] args)
        {         

            List<Characters> marvel = List.LoadInfo();

            marvel = marvel.Where(m => m.Publisher == "Marvel Comics").ToList();
            /*foreach(var characters in marvel)78070
            {
                Console.WriteLine(marvel);
            }*/
            Console.WriteLine(marvel.Count);
            Console.WriteLine(marvel[0].Id);
            Console.WriteLine(marvel[0].Publisher);
            Console.WriteLine(marvel[0].CharacterName);
            Console.WriteLine(marvel[0].Gender);
            //Console.WriteLine(string.Join("\t", marvel));
            //marvel.ForEach(i => Console.Write("{0}\t", i));
            //List<Characters> gender = List.LoadInfo();
            //gender = gender.Where(g => g.Gender == "Male".ToUpper).ToList();


            //Console.ReadLine();

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
            Console.WriteLine(" Select one of the following for find more information about Marvel & DC characters ! ");
            Console.WriteLine();
            Console.WriteLine("\t 1    Marvel");
            Console.WriteLine();
            Console.WriteLine("\t 2    DC");
            string userInput = Console.ReadLine();       
                                  

            if (userInput == "1")
            {   
                
               
                Console.Clear();
                Console.Title = " === Marvel_DC_Characters === ";                
                Console.WriteLine();
                Console.WriteLine(" There is 00 Good Characters and 00 Bad Characters ");
                Console.WriteLine();
                Console.WriteLine(" Select G for Super Heroes or B for Bad One ");
                Console.WriteLine();
                Console.ReadLine();

            }
        }
    }
}






