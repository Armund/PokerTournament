using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournament
{
    class Data
    {
        public List<Person> people;

        public string pathPerson = "D:\\ALEX\\proging\\PokerTournament\\PokerTournament\\Person.json";

        public Data()
        {
            people = new List<Person>();
        }

        public void ReadDataFromJson()
        {
            // TODO: сделать нормальный путь к файлу
            if (File.Exists(pathPerson))
                this.people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(pathPerson));
        }
        public void SaveDataInJson()
        {
            File.WriteAllText(pathPerson, JsonConvert.SerializeObject(people));
        }
    }
}
