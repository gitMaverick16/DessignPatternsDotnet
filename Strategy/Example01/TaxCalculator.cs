namespace Strategy.Example01
{
    public class TaxCalculator
    {
        private ITaxCalculationStrategy _strategy;
        public TaxCalculator(ITaxCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetCalculateTaxStrategy(ITaxCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateTaxAmount(decimal amount)
        {
            return _strategy.CalculateTax(amount);
        }
    }
}
