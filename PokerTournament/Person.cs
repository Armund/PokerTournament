using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournament
{
    class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string group { get; set; }

        public Person(string name_arg)
        {
            name = name_arg;
        }
    }
}
