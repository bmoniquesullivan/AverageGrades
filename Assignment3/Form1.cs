//Windows Application do calculate the average between 3 grades
//Created By Monique Sullivan
//Version 1.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create and Initialize Variables and accept input from TextBox
            int grade1;
            grade1 = int.Parse(textBox1.Text);
            int grade2;
            grade2 = int.Parse(textBox2.Text);
            int grade3;
            grade3 = int.Parse(textBox3.Text);

            
            //Calculate the Average between 3 grades 
            int averageGrade = (grade1 + grade2 + grade3) / 3;

            //If/Else Statement giving feedback to user about their grades
            if (averageGrade >= 90)
            {
                MessageBox.Show("You are doing great. You have an A");
            }
            else if (averageGrade >= 80)
            {
                MessageBox.Show("You are doing well. You have a B");
            }
            else if (averageGrade >= 70)
            {
                MessageBox.Show("You are doing OK. You have a C");
            }
            else if (averageGrade < 70)
            {
                MessageBox.Show("You need to improve. Ask your instructor for more help.");
            }
        }
    }
}
