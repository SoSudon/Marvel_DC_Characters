using System;
using System.Collections.Generic;
using System.Text;


namespace Marvel_DC_Characters
{
    class StartPage
    {       
        public string OpenStartPage()
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
            Console.WriteLine(" Select one of the following for find more information about Marvel & DC characters ! ");            
            Console.WriteLine("\n\t 1    Marvel");            
            Console.WriteLine("\n\t 2    DC");            
            Console.WriteLine("\n\t Q     Exit");
            var userInput = Console.ReadLine();
            return userInput; 
            
        }
    }
}
