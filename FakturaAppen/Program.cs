using FakturaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaAppen
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakturaSystem = new FakturaSystem();
            Part enPerson = fakturaSystem.SkapaPart("Marco Erice", "780622-9295");
            var beställning = fakturaSystem.SkapaBeställning(enPerson);
            var teddy = fakturaSystem.SkapaProdukt("Fluffy", 59M);
            var ponny = fakturaSystem.SkapaProdukt("Miniponny", 15000M);
            try
            {                              
                beställning.NyRad(teddy, 3);
                beställning.NyRad(ponny, 1);
                Console.WriteLine($"Beställningen är värd {beställning.Total}");
                var faktura = beställning.GenereraFaktura();
                Console.WriteLine(faktura);
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine("Hoppsan! Försök igen lite senare");
            }
           
        }
    }
}
