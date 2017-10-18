using PracticeLib;
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
            var personInfoConverter = new Practice();

            var birthDate = personNumber.Value.ToString("yyyy-MM-dd");
            var personName = name.Text;
            var thePhone = phone.Text;

            var convertedTextForm = personInfoConverter.FullText(birthDate, personName, thePhone);

            saveFileDialog1.ShowDialog();
            File.AppendAllText(saveFileDialog1.FileName, convertedTextForm);
            //File.AppendAllText(saveFileDialog1.FileName, $"{birthDate};");
            //File.AppendAllText(saveFileDialog1.FileName, $"{personName};");
            //File.AppendAllText(saveFileDialog1.FileName, $"{thePhone}.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Convert button
        {
            
            var fileContent = File.ReadAllText(openFileDialog1.FileName);
            string[] words = fileContent.Split(';');

            // string dateTime = words[0];
            DateTime dt = Convert.ToDateTime(words[0]);
            
            var age = (DateTime.Now.Year - dt.Year); 

            var textPart = $"{words[1]} är {age} år gammal och har mobilnr {words[2]}";
            saveFileDialog2.ShowDialog();
            File.AppendAllText(saveFileDialog2.FileName, textPart);
            
        }

        private void button3_Click(object sender, EventArgs e) // Choose file button
        {
            openFileDialog1.ShowDialog();
        }
    }
}
