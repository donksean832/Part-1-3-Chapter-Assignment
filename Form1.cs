using System;
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
        int age = 10;
        double height;
        private void Chapter3_Load(object sender, EventArgs e)
        {

            lblAgeGuide.Text = ("10");


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Name = nameInput.Text;
            
            height = Convert.ToDouble(IblUpDown.Value);

            lblGreetings.Text = ($"Hello {Name}, you have {82 - age} years left until you eat shit.");
            IblGreetings2.Text = ($"You are {2.72 - height}m shorter than the tallest person ever.");

        }

        private void trackInput_Scroll(object sender, EventArgs e)
        {
            age = trackInput.Value;
            lblAgeGuide.Text = ($"{age}");


        }

        
    }
}
