using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using CsvHelper;
using System.Linq;

namespace Marvel_DC_Characters
{
    public class Characters
    {       
        public string Publisher { get; set;}
        public string CharacterName { get; set; }
        public string Gender { get; set;}
        public string Alignment { get; set; }

        //Parse CSV Line
        public static Characters FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Characters characters = new Characters();
            characters.Alignment = values[8];
            characters.Publisher = values[7];
            characters.CharacterName = values[1];
            characters.Gender = values[2];
            return characters;
        }
        
    }

}
