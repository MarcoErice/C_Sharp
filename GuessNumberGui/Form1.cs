using GuessNumberLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGui
{
    public partial class Form1 : Form
    {
        private GuessNumber _game = new GuessNumber();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess2_Click(object sender, EventArgs e)
        {
            // do NOT use
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFeedback2.Text = _game.Feedback;

        }

        private void btnGuess2_Click_1(object sender, EventArgs e)
        {
            _game.Guess(int.Parse(txtGuess2.Text));
            lblFeedback2.Text = _game.Feedback;
        }

        private void txtGuess2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
