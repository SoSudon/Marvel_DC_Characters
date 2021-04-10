using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;

namespace Marvel_DC_Characters
{
    class List
    {
        public static List<Characters> LoadInfo()
        {            
            List<Characters> output = new List<Characters>();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "heroes_information_marvel_dc.csv");
            var fileContents = ReadHeroesResults(fileName);
            output = fileContents;
            return output;
        }       

      
        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<Characters> ReadHeroesResults(string fileName)
        {
            List<Characters> heroesResults = new List<Characters>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    heroesResults.Add(new Characters 
                    { 
                        Id = values[0], 
                        Publisher = values[7], 
                        CharacterName = values[1], 
                        Gender = values[2]
                    });
                }
            }
            return heroesResults;
        }
       
    }

}

