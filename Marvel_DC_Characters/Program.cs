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
            // Write Results to Console
            static void WriteResults(List<Characters> listToOutput)
            {
                foreach (var character in listToOutput)
                {
                    var OutputString = character.CharacterName + "-" + character.Gender + "-" + character.Publisher + "-" + character.Alignment;
                    Console.WriteLine(OutputString); 
                }
            }

            static bool CheckInput(string userInput, int maxValue)
            {
                bool result = false;
                try
                {
                    Int32.Parse(userInput);
                    if (Int32.Parse(userInput) > 0 && Int32.Parse(userInput) <= maxValue)
                    { result = true; }
                    else { result = false; }
                }
                catch { result = false; }
                
                if(userInput.ToLower() == "q" || userInput.ToLower() == "m")
                {
                    result = true;
                }

                return result;
            }

            //Load CSV file into List
            List<Characters> characterList = List.LoadInfo();
            string userInput;
            var startPage = new StartPage();            
            userInput = startPage.OpenStartPage();

            
                        
            //Console.Title = " === Marvel_DC_Characters === ";
            //Console.WriteLine(@"
            //              __  __                      _            _____   _____ 
            //             |  \/  |                    | |   ___    |  __ \ / ____|
            //             | \  / | __ _ _ ____   _____| |  ( _ )   | |  | | |     
            //             | |\/| |/ _` | '__\ \ / / _ \ |  / _ \/\ | |  | | |     
            //             | |  | | (_| | |   \ V /  __/ | | (_>  < | |__| | |____ 
            //             |_|  |_|\__,_|_|    \_/ \___|_|  \___/\/ |_____/ \_____|                                                  
                                                  
            //           ");

            ////Request Input From User
            //Console.WriteLine(" Select one of the following for find more information about Marvel & DC characters ! ");
            //Console.WriteLine();
            //Console.WriteLine("\t 1    Marvel");
            //Console.WriteLine();
            //Console.WriteLine("\t 2    DC");
            //Console.WriteLine();
            //Console.WriteLine("\t Enter Any Other KEY to Exit Out");
            

            // Loop until User insert correct value
            while (true)
            {
                //userInput = Console.ReadLine();    
              
                if (CheckInput(userInput, 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" Please select from List");
                }                
            }
      

            string field = "Publisher";
            string publisherSelected = "";
            if (userInput == "1")
            {
                publisherSelected = "Marvel Comics";
            }
            if (userInput == "2")
            {
                publisherSelected = "DC Comics";
            }          
            
            characterList = List.FilterList(characterList, field , publisherSelected);
            //int goodCount = List.FilterList(characterList, "Alignment", "good").Count;
            //int badCount = List.FilterList(characterList, "Alignment", "bad").Count;
            //int neutralCount = List.FilterList(characterList, "Alignment", "neutral").Count;
            //int nullCount = List.FilterList(characterList, "Alignment", "null").Count;
            //int otherCount = neutralCount + nullCount;
            //int maleCount = List.FilterList(characterList, "Gender", "male").Count;
            //int womenCount = List.FilterList(characterList, "Gender", "female").Count;

            //int goodCount = characterList.Where(g => g.Alignment.ToLower() == "good").ToList().Count;
            //int badCount = characterList.Where(g => g.Alignment.ToLower() == "bad").ToList().Count;
            //int neutralCount = characterList.Where(g => g.Alignment.ToLower() == "neutral").ToList().Count;
            //int nullCount = characterList.Where(g => g.Alignment.ToLower() == "null").ToList().Count;

            //FilterList(List<Characters> mylist, string field, string value)
            var good = List.FilterList(characterList, "Alignment", "good");
            var bad = List.FilterList(characterList, "Alignment", "bad");
            var neutral = List.FilterList(characterList, "Alignment", "neutral");
            var null1 = List.FilterList(characterList, "Alignment", "null");
            var other = neutral.Concat(null1).ToList();
            var male = List.FilterList(characterList, "Gender", "male");
            var women = List.FilterList(characterList, "Gender", "female");

            if (userInput == "q")
            {
                Environment.Exit(-1);
            }
            else
            {
                Console.Clear();
                Console.Title = " === Marvel_DC_Characters === ";
                Console.WriteLine();
                Console.WriteLine($" There are a total of {characterList.Count} {publisherSelected} Characters ");
                Console.WriteLine();
                Console.WriteLine($" There are {good.Count} Heroes, {bad.Count} Bad, and {other.Count} Neutral Characters");
                Console.WriteLine();
                Console.WriteLine($"There are {male.Count} Male Characters and {women.Count} Women Characters");
                Console.WriteLine();


                
                //Page 2
                Console.WriteLine();
                Console.WriteLine(" Find out Characters in below each items, select the number");
                Console.WriteLine();
                Console.WriteLine("\t 1    Good Heroes");
                Console.WriteLine("\t 2    Bad Characters");
                Console.WriteLine("\t 3    Neutral Characters");
                Console.WriteLine("\t 4    Male Heroes");
                Console.WriteLine("\t 5    Women Heroes");
                Console.WriteLine();
                Console.WriteLine("M     Go Back to Main Menu");
                Console.WriteLine();
                Console.WriteLine("Q     Exit");
            }

            while (true)
            {
                userInput = Console.ReadLine();
                if (CheckInput(userInput, 5))
                {
                    break;
                }               
                else
                {
                    Console.WriteLine(" Please select from List");
                }
            }

            if (userInput.ToLower() == "q")
            {
                Environment.Exit(-1);
            }
            
            else
            {
                Console.Clear();
                if (userInput == "1")
                {
                    WriteResults(good);
                }
                if (userInput == "2")
                {
                    WriteResults(bad);
                }
                if (userInput == "3")
                {
                    WriteResults(other);
                }
                if (userInput == "4")
                {
                    WriteResults(male);
                }
                if (userInput == "5")
                {
                    WriteResults(women);
                }
                if (userInput.ToLower() == "m")
                {
                    startPage.OpenStartPage();
                }
                if (userInput.ToLower() == "q")
                {
                    Environment.Exit(-1);
                }
            }


            //characterList = characterList.Where(g => g.CharacterName.ToLower().Contains("trickster")).ToList();
            //WriteResults(characterList);


        }
    }
}






