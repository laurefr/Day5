using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemoQuizz
{
    public partial class Form1 : Form
    {
        
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;
        //private object buttonBegin;

        public Form1()
        {// make picture visisble by changing to true boolean
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
// To see the group box outline change the boolean to true
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got all the questions right.", "Well done!");
            }
            else if (timeLeft > 0)
            {
                //update & display time left
                timeLeft--;
                labelTimeLeft.Text = timeLeft + " seconds";
            }
            else
            {
                //if the user runs out of time
                timer1.Stop();
                labelTimeLeft.Text = "Time's up!";
                MessageBox.Show("You ran out of time.", "Sorry");
            }
        }
        private void buttonBegin_Click(object sender, EventArgs e)
     
        {
            timer1.Start();
            buttonBegin.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A.Checked)
            {
                labelAnswerQ1.ForeColor = Color.Green;
                labelAnswerQ1.Text = "\u00fc";  //cross
                q1Correct = true;
            }
            else
            {
                labelAnswerQ1.Text = "";
            }
        }
        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1B.Checked)
            {
                labelAnswerQ1.ForeColor = Color.Red;
                labelAnswerQ1.Text = "\u00fb";  //tick
                q1Correct = false;
            }
            else
            {
                labelAnswerQ1.Text = "";
            }
        }
        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1C.Checked)
            {
                labelAnswerQ1.ForeColor = Color.Red;
                labelAnswerQ1.Text = "\u00fb";  //cross
                q1Correct = true;
            }
            else
            {
                labelAnswerQ1.Text = "";
            }
        }
        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A.Checked)
            {
                labelQ2Answer.ForeColor = Color.Red;
                labelQ2Answer.Text = "\u00fb";  //cross
                q2Correct = false;
            }
            else
            {
                labelQ2Answer.Text = "";
            }
        }
        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2B.Checked)
            {
                labelQ2Answer.ForeColor = Color.Green;
                labelQ2Answer.Text = "\u00fc";  //tick
                q2Correct = true;
            }
            else
            {
                labelQ2Answer.Text = "";
            }
        }
        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2C.Checked)
            {
                labelQ2Answer.ForeColor = Color.Red;
                labelQ2Answer.Text = "\u00fb";  //cross
                q2Correct = false;
            }
            else
            {
                labelQ2Answer.Text = "";
            }
        }
        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A.Checked)
            {
                labelQ3Answer.ForeColor = Color.Red;
                labelQ3Answer.Text = "\u00fb";  //cross
                q3Correct = false;
            }
            else
            {
                labelQ3Answer.Text = "";
            }
        }
        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3B.Checked)
            {
                labelQ3Answer.ForeColor = Color.Red;
                labelQ3Answer.Text = "\u00fb";  //cross
                q3Correct = false;
            }
            else
            {
                labelQ3Answer.Text = "";
            }
        }
        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3C.Checked)
            {
                labelQ3Answer.ForeColor = Color.Green;
                labelQ3Answer.Text = "\u00fc";  //tick
                q3Correct = true;
            }
            else
            {
                labelQ3Answer.Text = "";
            }
        }

   
    }
}
       

       

