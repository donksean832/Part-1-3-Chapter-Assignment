﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_Chapter_Assignment
{
    public partial class Chapter3 : Form
    {
        public Chapter3()
        {
            InitializeComponent();
            

        }
        string Name;
        int age;



        private void button1_Click(object sender, EventArgs e)
        {
            Name = nameInput.Text;
            age = trackInput.Value;
            Greetings.Text = ($"Hello {Name}, you are {age} years old");
            
        }

    }
}
