using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournament
{
    class Landing
    {
        public int tableNumber;
        public int playersAtTheTable;
        public int playersAtTournament;
        public List<List<Person>> tables;

        public void makeLanding(List<Person> people)
        {
            List<Person> bufPeople = new List<Person>();
            for (int i = 0; i < people.Count; i++)
            {
                bufPeople.Add(people[i]);
            }
            Random rnd = new Random();
            int currentPerson;
            for (int i = 0; i < playersAtTheTable; i++)
            {
                for (int j = 0; j < tableNumber; j++)
                {
                    if (bufPeople.Count > 0)
                    {
                        currentPerson = rnd.Next(0, bufPeople.Count);
                        tables[j][i] = bufPeople[currentPerson];
                        bufPeople.RemoveAt(currentPerson);
                    }
                }
            }
        }

        public void printLanding() // TODO сделать принт в листбокс? 
        {
            for (int i = 0; i < tables.Count; i++)
            {
                Console.WriteLine($"Table {i + 1}:");
                for (int j = 0; j < tables[i].Count; j++)
                {
                    Console.WriteLine($"Place {j + 1}: {tables[i][j].ToString()}");
                }
            }
        }

        public Landing(List<Person> people)
        {
            playersAtTheTable = 9;
            tableNumber = (int)Math.Ceiling(people.Count / (double)playersAtTheTable);            
            tables = new List<List<Person>>();
            for (int i = 0; i < tableNumber; i++) // заполнение массива столов и столов пустыми экземплярами
            {
                tables.Add(new List<Person>());
                for (int j = 0; j < playersAtTheTable; j++)
                {
                    tables[i].Add(new Person());
                }
            }
        }
    }
}
