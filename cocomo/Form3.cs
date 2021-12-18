using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cocomo
{
    //this is a comment.
    public partial class Form3 : Form
    {
        public static int kcode;
        public static double effort;
        public static double TDEV;
        public static int newEffort;
        public double[] organic = { 3.2, 1.05, 2.5, 0.38 };
        public double[] semidetached = { 3.0, 1.12, 2.5, 0.35 };
        public double[] embedded = { 2.8, 1.20, 2.5, 0.32 };


        public Form3()
        {
            InitializeComponent();
        }

        /*public void Ecalc()
        {
            kcode = Convert.ToInt32(textBox1.Text);
            if (kcode >= 2 || kcode <= 50)
            {
                calculateEffort(organic[0], organic[1]);
            }
            else if (kcode > 50 || kcode <= 300)
            {
                calculateEffort(semidetached[0], semidetached[1]);

            }
            else if (kcode > 300)
            {
                calculateEffort(embedded[0], embedded[1]);
            }
            else
            {
                string message2 = "please enter a valid KLOC value.";
                string title2 = "Invalid Input!";
                MessageBox.Show(message2, title2);
            }
        }*/

        /*public void TDEVcalc()
        {
            kcode = Convert.ToInt32(textBox1.Text);
            if (kcode >= 2 || kcode <= 50)
            {
                calculateTDEV(organic[0], organic[1]);
            }
            else if (kcode > 50 || kcode <= 300)
            {
                calculateTDEV(semidetached[0], semidetached[1]);

            }
            else if (kcode > 300)
            {
                calculateTDEV(embedded[0], embedded[1]);
            }
            else
            {
                string message2 = "please enter a valid KLOC value.";
                string title2 = "Invalid Input!";
                MessageBox.Show(message2, title2);
            }
        }*/

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to resume without choosing project type?";
            string title = "specify project type";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                panel1.Visible = false;

            }
            else
            {
                panel1.Visible = true;
            }

            kcode = Convert.ToInt32(textBox1.Text);
            if (kcode >= 2 && kcode <= 50)
            {
                calculateEffort(organic[0], organic[1]);
            }
            else if (kcode > 50 && kcode <= 300)
            {
                calculateEffort(semidetached[0], semidetached[1]);

            }
            else if (kcode > 300)
            {
                calculateEffort(embedded[0], embedded[1]);
            }
            else
            {
                string message2 = "please enter a valid KLOC value.";
                string title2 = "Invalid Input!";
                MessageBox.Show(message2, title2);
            }
             newEffort = Convert.ToInt32(effort);

            label3.Text = newEffort.ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string message = "Do you want to resume without choosing project type?";
            string title = "specify project type";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
               
            }
            else
            {
                panel1.Visible = true;
            }

            kcode = Convert.ToInt32(textBox1.Text);
            if (kcode >= 2 && kcode <= 50)
            {
                calculateTDEV(organic[2], organic[3]);
            }
            else if (kcode > 50 && kcode <= 300)
            {
                calculateTDEV(semidetached[2], semidetached[3]);

            }
            else if (kcode > 300)
            {
                calculateTDEV(embedded[2], embedded[3]);
            }
            else
            {
                string message2 = "please enter a valid KLOC value.";
                string title2 = "Invalid Input!";
                MessageBox.Show(message2, title2);
            }
            int newTDEV = Convert.ToInt32(TDEV);
            label4.Text = newTDEV.ToString();
        }
        public void calculateEffort(double a, double b)
        {
            effort = a * Math.Pow(kcode, b);
        }
        public void calculateTDEV(double c, double d)
        {
            TDEV = c * Math.Pow(effort, d);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 newform = new Form2();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }
    }
}
