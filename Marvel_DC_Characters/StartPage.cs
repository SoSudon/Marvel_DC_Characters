using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Marvel_DC_Characters
{
    class StartPage
    {
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
        public void OpenStartPage()
        {
            List<Characters> characterList = List.LoadInfo();
            
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
            Console.WriteLine("\n\t 1    Marvel");
            Console.WriteLine("\n\t 2    DC");
            Console.WriteLine("\n\t Q     Exit");
            string userInput; // = Console.ReadLine();
            //return userInput;

            while (true)
            {
                userInput = Console.ReadLine();    

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

            characterList = List.FilterList(characterList, field, publisherSelected);

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
                Console.WriteLine($"\n There are a total of {characterList.Count} {publisherSelected} Characters ");                
                Console.WriteLine($"\n There are {good.Count} Heroes, {bad.Count} Bad, and {other.Count} Neutral Characters");                
                Console.WriteLine($"\n There are {male.Count} Male Characters and {women.Count} Women Characters");
                
                Console.WriteLine("\n\n Find out Characters in below each items, select the number");                
                Console.WriteLine("\n\t 1    Good Heroes");
                Console.WriteLine("\n\t 2    Bad Characters");
                Console.WriteLine("\n\t 3    Neutral Characters");
                Console.WriteLine("\n\t 4    Male Heroes");
                Console.WriteLine("\n\t 5    Women Heroes");                
                Console.WriteLine("\nM     Go Back to Main Menu");
                Console.WriteLine("\nQ     Exit");
            }

            //var checkInput = Console.ReadLine();
            SecondPage(characterList);
          
        }

        public void SecondPage(List<Characters> blahblah)
        {
            string userInput;
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

            var good = List.FilterList(blahblah, "Alignment", "good");
            var bad = List.FilterList(blahblah, "Alignment", "bad");
            var neutral = List.FilterList(blahblah, "Alignment", "neutral");
            var null1 = List.FilterList(blahblah, "Alignment", "null");
            var other = neutral.Concat(null1).ToList();
            var male = List.FilterList(blahblah, "Gender", "male");
            var women = List.FilterList(blahblah, "Gender", "female");


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
                    OpenStartPage();
                }
                if (userInput.ToLower() == "q")
                {
                    Environment.Exit(-1);
                }
            }

        }

        // Write Results to Console
        static void WriteResults(List<Characters> listToOutput)
        {
            foreach (var character in listToOutput)
            {
                var OutputString = character.CharacterName + "-" + character.Gender + "-" + character.Publisher + "-" + character.Alignment;
                Console.WriteLine(OutputString);
            }
        }

    }
}
