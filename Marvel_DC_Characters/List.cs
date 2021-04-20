using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Marvel_DC_Characters
{
    class List
    {
        //Load CSV file
        public static List<Characters> LoadInfo()
        {            
            List<Characters> output = new List<Characters>();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "heroes_information_marvel_dc.csv");
            output = ReadHeroesResults(fileName);            
            return output;
        }        
        //Parses file
        static List<Characters> ReadHeroesResults(string fileName)
        {
            List<Characters> heroesResults = new List<Characters>();
            heroesResults = File.ReadAllLines(fileName).Skip(1).Select(v => Characters.FromCsv(v)).ToList();          
            return heroesResults;
        }

        //Filter the List
        public static List<Characters> FilterList(List<Characters> mylist, string field, string value)
        {
            value = value.ToLower();

            if (field == "Publisher")
            {
                mylist = mylist.Where(m => m.Publisher.ToLower() == value).ToList();
            }
            if (field == "Alignment")
            {
                mylist = mylist.Where(m => m.Alignment.ToLower() == value).ToList();
            }
            if (field == "Gender")
            {
                mylist = mylist.Where(m => m.Gender.ToLower() == value).ToList();
            }
            if (field == "CharacterName")
            {
                mylist = mylist.Where(m => m.CharacterName.ToLower() == value).ToList();
            }

            return mylist;
        }
       
    }

}

