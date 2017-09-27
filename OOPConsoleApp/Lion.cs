// Obejkt Orienterad Programmering.
namespace OOPConsoleApp
{
    internal class Lion : Animal
    {
        public Lion()
        {
        }
        internal override void Eat()
        {
            base.Eat();
            System.Console.WriteLine("Hunting prey.");
        }

    }
}