﻿using System;
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
    public partial class MainForm : Form
    {
        Data data = new Data();

        public MainForm()
        {
            //Data data 
            this.data.ReadDataFromJson();
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person(textBoxName.Text);
            this.data.people.Add(person);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.SaveDataInJson();
        }
    }
}