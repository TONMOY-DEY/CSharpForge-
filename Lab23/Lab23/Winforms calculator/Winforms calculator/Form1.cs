using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {

                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int result1 = num1 + num2;
                int result2=num1 - num2;
                int result3 = num1 * num2;
                double result4 = num1 / num2;

                label4.Text = "Addition result is:" + result1.ToString();
                label4.Visible = true;
            }

            else
            {
                MessageBox.Show("Please fill both fienlds !!");
            }



            //MessageBox.Show("Addition result is:"+result1.ToString());
            //MessageBox.Show("Subtraction result is:"+result2.ToString());
            //MessageBox.Show("Multiplication result is:" + result3.ToString());
            //MessageBox.Show("Devision result is:"+result4.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
