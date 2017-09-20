using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWindowsApp
{
    public partial class Form1 : Form
    {
        private Exam cSharpExam = new Exam("cSharp");
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var newStudent = new Student(tB1.Text);
            cSharpExam.Assign(newStudent);
            cB1.Items.Add(newStudent);


        }

        private void cB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            cSharpExam.Grade((Student)cB1.SelectedItem, cB2.SelectedItem.ToString());
        }

        private void cB2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateStatistics_Click(object sender, EventArgs e)
        {
            var statistics = cSharpExam.GenerateStatistics();
            var ig = statistics["IG"];
            var g = statistics["G"];
            var vg = statistics["VG"];
            label1.Text = $"IG: {ig}";
            label2.Text = $"G: {g}";
            label3.Text = $"VG: {vg}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
