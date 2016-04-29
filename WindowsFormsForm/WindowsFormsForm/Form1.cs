using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsForm
{
    public partial class Form1 : Form
    {
        string name = "";
        private int years;
        private int day;
        private string month;

        public Form1()
        {
            InitializeComponent();
        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan agedays = today - dateTimePicker1.Value;
            int years = ((int)agedays.TotalDays) / 365;
            int day = dateTimePicker1.Value.Day;
            string month = dateTimePicker1.Value.ToString("MMM");


            labelBirthdayMessage.Text = " Hello  ," + name + " will be" + " " + (years + 1) + " " + "years old on" + " " + day + " " + month + ".";
        }
          
        
        private void textBoxName_TextChanged_1(object sender, EventArgs e)
        {
            name = textBoxName.Text;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                labelBirthdayMessage.Text = " Hello your name ," + name + " will be" + " " + (years + 1) + " " + "years old on" + " " + day + " " + month + ".";

            else
            {
            }
        }
    }
    }

