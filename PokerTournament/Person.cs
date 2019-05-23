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
        public bool isStudent { get; set; }

        public Person(int id, string Name, string Group, bool IsStudent)
        {
            ID = id;
            name = Name;
            group = Group;
            isStudent = IsStudent;
        }

        override public string ToString()
        {
            string student;
            if (isStudent) // TODO: Переписать тернарным оператором
            {
                student = "Да";
            } else
            {
                student = "Нет";
            };
            return $"ID: {ID}  Имя: {name}  Группа: {group} Студент: {student}";
        }

    }
}
