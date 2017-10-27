using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaLib
{
    public class FakturaSystem
    {
        public Part SkapaPart(string namn, string juridiskId)
        {
            var enPerson = new Part
            {
                Namn = namn,
                JuridiskId = juridiskId
            };return enPerson;
        }

        public Beställning SkapaBeställning(Part enPerson)
        {
            return new Beställning(enPerson);
        }

        public Produkt SkapaProdukt(string namn, decimal pris)
        {
            return new Produkt(namn, pris);
        }
    }
}
