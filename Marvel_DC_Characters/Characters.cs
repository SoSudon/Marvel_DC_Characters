using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using CsvHelper;

namespace Marvel_DC_Characters
{
    public class Characters
    {       
        public string Publisher { get; set;}
        public string CharacterName { get; set; }
        public string Gender { get; set;}
        public string Id { get; set; }

        public Characters()//string publisher, string characgterName, string gender)
        {

        }
       /* public override string ToString()
        {
            return string.Format("CharacterName{}\n", CharacterName);
        }*/
       
        
    }

}
