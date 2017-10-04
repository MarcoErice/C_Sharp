using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonNumberApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = textBox1.Text;
            var lastName = textBox2.Text;
            var personNumber = textBox3.Text;
            var substringWithHyphen = int.Parse(personNumber.Substring(9, 1));
            var substringNoHyphen = int.Parse(personNumber.Substring(8, 1));
            var hyphen = personNumber.Substring(6, 1);
            if (hyphen == "-")
            {
                if (substringWithHyphen % 2 == 0)
                {
                    label4.Text = $"God morgon fröken {lastName}";
                }
                else
                {
                    label4.Text = $"God morgon herr {lastName}";
                }

            }
            else
            {

                if (substringNoHyphen % 2 == 0)
                {
                    label4.Text = $"God morgon fröken {lastName}";
                }
                else
                {
                    label4.Text = $"God morgon herr {lastName}";
                }

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
