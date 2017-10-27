using System;

namespace DagisAppen
{
    internal class Klossbräda
    {
        public Klossbräda()
        {
        }

        internal void Acceptera(ICircular circularObject)
        {
            Console.WriteLine("En boll har passerat");
            Console.ReadLine();
        }

        internal void Acceptera(Blyboll blyboll)
        {
            throw new NotImplementedException();
        }
    }
}