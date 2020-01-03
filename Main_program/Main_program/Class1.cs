using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_program
{
    [Serializable]
    public class Data
    {
        public string FIO;
        public int year;
        public string education;
        public string language;
        public string levelOfLanguage;
        public int computerSkill;
        public string recomendations;
        public Data(string FIO, int year, string education, string language, string levelOfLanguage, int computerSkill, string recomendations)
        {
            this.FIO = FIO;
            this.year = year;
            this.education = education;
            this.language = language;
            this.levelOfLanguage = levelOfLanguage;
            this.computerSkill = computerSkill;
            this.recomendations = recomendations;
        }
        [NonSerialized]
        public static string SerializationDate = DateTime.Now.ToString();

        public override string ToString()
        {
            return $"{FIO}\r\n{year}\r\n{education}\r\n{language}\r\n{levelOfLanguage}\r\n{computerSkill}\r\n{recomendations}";
        }
    }
}
