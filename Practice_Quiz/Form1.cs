using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            question1OutputLabel.Text = "Happy";
        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            string username = question2TextBox.Text;
            question2OutputLabel.Text = "hello "+username;
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2;
                num1 = int.Parse(q3Int1Text.Text);
                num2 = int.Parse(q3int2Text.Text);
                double total = num1 * num2;


                question3OutputLabel.Text = num1 + " X " + num2 + " = " + total.ToString();
            }
            catch
            {
                question3OutputLabel.Text = "please enter the number";
            }
            

            

        }
    }
}
