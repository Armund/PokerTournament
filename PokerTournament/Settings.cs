using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PokerTournament
{
    public partial class Settings : Form
    {
        Data data = new Data();

        public Settings()
        {
            //Data data 
            this.data.ReadDataFromJson();
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Person person = new Person(textBoxName.Text);
            //this.data.people.Add(person);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.SaveDataInJson();
        }

        private void buttonListbox_Click(object sender, EventArgs e)
        {
            listBoxPersons.Items.Clear();
            data.ReadDataFromXLS();
            for (int i = 0; i < data.people.Count; i++)
            {
                listBoxPersons.Items.Add(data.people[i].ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClearPeople_Click(object sender, EventArgs e)
        {
            data.people.Clear();
            data.landing.tables.Clear();
            listBoxPersons.Items.Clear();
        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            listBoxPersons.Items.Clear();
            data.landing = new Landing(data.people);
            data.landing.makeLanding(data.people);
            for (int i = 0; i < data.landing.tables.Count; i++)
            {
                listBoxPersons.Items.Add($"Table {i + 1}:");
                for (int j = 0; j < data.landing.tables[i].Count; j++)
                {
                    listBoxPersons.Items.Add($"Place {j + 1}: {data.landing.tables[i][j].ToString()}");
                }
            }
        }
    }
}
