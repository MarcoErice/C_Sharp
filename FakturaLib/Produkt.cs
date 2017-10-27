using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaLib
{
    public class Produkt
    {
        public Produkt(string namn, decimal pris)
        {
            if (pris < 0)
            {
                throw new InvalidOperationException("Pris måste vara större än 0");
            }
            this.ProduktNamn = namn;
            this.ProduktPris = pris;
        }
        public string ProduktNamn { get; set; }
        public decimal ProduktPris { get; set; }
        public override string ToString()
        {
            return this.ProduktNamn;
        }
    }
}
