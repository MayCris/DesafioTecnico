namespace APICalculo.Classes
{
    public class Retorno
    {
        private decimal TaxaJuros;
        private decimal ValorInicial { get; set; }
        private int Meses { get; set; }
        private decimal ValorFinal { get; set; }
        public decimal Resultado { get; set; }

        public void CalcularJuros(decimal valorInicial, int meses, decimal taxaJuros)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            TaxaJuros = taxaJuros;

            CalcularJuros();
        }

        private void CalcularJuros()
        {
            ValorFinal = ValorInicial;

            for (int i = 0; i < Meses; i++)
            {
                ValorFinal = ValorFinal * (1 + TaxaJuros);
            }

            Resultado = Math.Round(ValorFinal, 2);
        }
    }
}