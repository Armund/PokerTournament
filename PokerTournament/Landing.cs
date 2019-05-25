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
        public int mode; // 0-рассадки нет. 1-сделана начальная рассадка.
        public List<List<Person>> tables;

        public void makeLanding(List<Person> people)
        {
            List<Person> bufPeople = new List<Person>();
            for (int i = 0; i < people.Count; i++) // лист передаётся по ссылке
            {
                bufPeople.Add(people[i]);
            }
            Random rnd = new Random();
            

            switch (mode)
            {
                case 0:
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
                    mode = 1;
                    break;
                case 1:
                    int currentTable;
                    
                    currentTable = rnd.Next(0, tableNumber);

                    break;
            }            
        }

        public int countEmptyPlaces (int table) //Посчитать количество свободных мест за столом
        {
            int count = 0;

            foreach (Person person in tables[table])
            {
                if (person.ID == 0) count++;
            }

            return count;
        }
        public int countTablesWithPlaces ()
        {
            int count = 0;
            // TODO ВОТ ЗДЕСЬ
            return count;
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
            mode = 0;
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
