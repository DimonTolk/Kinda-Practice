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
        public string computerSkill;
        public string recomendations;
        [NonSerialized]
        public static string SerializationDate = DateTime.Now.ToString();
    }
}
