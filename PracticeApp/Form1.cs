using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var birthDate = personNumber.Text;
            var personName = name.Text;
            var thePhone = phone.Text;

            saveFileDialog1.ShowDialog();
            File.AppendAllText(saveFileDialog1.FileName, $"{birthDate};");
            File.AppendAllText(saveFileDialog1.FileName, $"{personName};");
            File.AppendAllText(saveFileDialog1.FileName, $"{thePhone}.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
