using FakturaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaWinApp
{
    public partial class Form1 : Form
    {
        private FakturaSystem fakturaSystem = new FakturaSystem();
        private Part part;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaPart_Click(object sender, EventArgs e)
        {
            part = fakturaSystem.SkapaPart(txtNamn.Text, txtJuridiskId.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbVäljProdukt.Items.Add(fakturaSystem.SkapaProdukt("Fluffy", 59M));
            cbVäljProdukt.Items.Add(fakturaSystem.SkapaProdukt("Miniponny", 15000M));
        }

        private void btnNyRad_Click(object sender, EventArgs e)
        {
            lbProdukt.Items.Add(
                new Rad
                {
                    Produkt = (Produkt)cbVäljProdukt.SelectedItem,
                    Antal = int.Parse(cbAntal.SelectedItem.ToString())
                }
            );
        }

        private void btnLäggBeställning_Click(object sender, EventArgs e)
        {
            var beställning = fakturaSystem.SkapaBeställning(part);
            foreach (Rad rad in lbProdukt.Items)
            {
                beställning.NyRad(rad.Produkt, rad.Antal);
            }
            var faktura = beställning.GenereraFaktura();
            MessageBox.Show(faktura.ToString());
        }
    }
}
