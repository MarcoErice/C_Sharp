using System;

namespace DagisAppen
{
    internal class Klossbräda
    {
        public Klossbräda()
        {
        }

      
        internal void Accept(ICircular circularObject)
        {
            Console.WriteLine("Ett cirkulär objekt har passerat");
            
        }

        internal void Accept(IRectangular rectangularObject)
        {
            Console.WriteLine("Ett rektangulär objekt har passerat");
            
        }
    }
}