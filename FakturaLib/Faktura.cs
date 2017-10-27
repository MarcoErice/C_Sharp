namespace FakturaLib
{
    public class Faktura
    {
        public Faktura(Part kund, decimal total)
        {
            _kund = kund;
            _total = total;
        }
        private Part _kund;
        private decimal _total;
        public override string ToString()
        {
            return $"Kund {_kund.Namn} ska betala {_total} SEK";
        }
    }
}