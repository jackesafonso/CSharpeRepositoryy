using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo2
{

    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = true;
        bool q3Correct = false;



        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 60;

            timer1.Start();
        }

       




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // update and display the time left
                timeLeft--;
                labelTimeLeft.Text = timeLeft + " seconds";
            }
            else
            {
                // if the user runs out of time
                timer1.Stop();

                labelTimeLeft.Text = "Time is up";
                MessageBox.Show("You ran out of time.", "Sorry");
            }
        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A1.Checked)
            {
                labelQ1Feedback.ForeColor = Color.Red;
                labelQ1Feedback.Text = "\u00fb"; //cross
                q1Correct = false;
            }

            else
            {
                labelQ1Feedback.Text = "";
            }



        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelQ1Feedback.ForeColor = Color.Green;
                labelQ1Feedback.Text = "\u00fc"; //tick
                q2Correct = true;
            }
            else
            {
                labelQ1Feedback.Text = "";
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelQ1Feedback.ForeColor = Color.Red;
                labelQ1Feedback.Text = "\u00fb"; //cross
                q3Correct = false;
            }

            else
            {
                labelQ1Feedback.Text = "";
            }
        }
    }
}
