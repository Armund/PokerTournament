using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace PokerTournament
{
    class Data
    {
        public List<Person> people;

        public string pathPersonJson = "D:\\ALEX\\proging\\PokerTournament\\PokerTournament\\Person.json";
        public string pathPersonXLS = @"D:\ALEX\proging\PokerTournament\PokerTournament\Registratsia_na_mayskie_turniry_2019-05-23.xls";

        public Data()
        {
            people = new List<Person>();
        }

        public void ReadDataFromJson()
        {
            // TODO: сделать нормальный путь к файлу
            if (File.Exists(pathPersonJson))
                this.people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(pathPersonJson));
        }
        public void ReadDataFromXLS()
        {
            // TODO: сделать нормальный путь к файлу
            if (File.Exists(pathPersonXLS))
            {
                Excel.Application excelapp = new Excel.Application();
                //var excelappworkbooks = excelapp.Workbooks;
                var excelappworkbook = excelapp.Workbooks.Open(pathPersonXLS);
                var excelsheets = excelappworkbook.Worksheets;
                //Получаем ссылку на лист 1
                var excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
                //Выбираем ячейку для вывода A1

                int ID = 0, i = 1;
                string name = "", group = "", tournament;
                do
                {
                    i++;
                    tournament = Convert.ToString(excelworksheet.get_Range("I" + i).Value2);
                    if (tournament == "Онлайн-турнир, Оффлайн-турнир" || tournament == "Оффлайн-турнир")
                    {
                        ID = Convert.ToInt32(excelworksheet.get_Range("A" + i).Value2);
                        name = Convert.ToString(excelworksheet.get_Range("D" + i).Value2) + " " + Convert.ToString(excelworksheet.get_Range("E" + i).Value2);
                        group = Convert.ToString(excelworksheet.get_Range("H" + i).Value2);
                        people.Add(new Person(ID, name, group, Convert.ToString(excelworksheet.get_Range("H" + i).Value2) == "Да"));                           
                    }
                } while (tournament != null);
            }
        }
        public void SaveDataInJson()
        {
            File.WriteAllText(pathPersonJson, JsonConvert.SerializeObject(people));
        }
    }
}
