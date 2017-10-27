using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaLib
{
    public class Beställning
    {
        public Beställning(Part beställare)
        {
            this.Beställare = beställare;
        }
        private Part Beställare;
        private List<Tuple<Produkt, int>> rader = new List<Tuple<Produkt, int>>();

        public decimal Total {
            get
            {
                return rader.Sum(rad => rad.Item1.ProduktPris * rad.Item2);
            }
        }

        public void NyRad(Produkt produkt, int antal)
        {
            rader.Add(new Tuple<Produkt, int>(produkt, antal));
        }

        public Faktura GenereraFaktura()
        {
            return new Faktura(Beställare, this.Total);
        }
    }
}
