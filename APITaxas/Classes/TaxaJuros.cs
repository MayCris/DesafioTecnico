namespace APITaxas.Classes
{
    public class TaxaJuros
    {
        private decimal taxaBaseJuros => (decimal)0.01;

        public decimal TaxaBaseJuros { get; set; }

        public decimal ConsultaTaxaJuros()
        {
            TaxaBaseJuros = taxaBaseJuros;
            return TaxaBaseJuros;
        }
    }
}