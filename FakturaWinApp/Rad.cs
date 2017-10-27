using FakturaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaWinApp
{
    internal class Rad
    {
        public Produkt Produkt { get; set; }
        public int Antal { get; set; }
        public override string ToString()
        {
            return $"{Produkt.ProduktNamn} {Antal} {Produkt.ProduktPris} {Antal * Produkt.ProduktPris}";
        }
    }
}
