namespace Strategy.Example01
{
    public class PeruTaxCalculationStrategy : ITaxCalculationStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            //All the logic to calculate taxes in Perú
            return amount * 0.20m;
        }
    }
}
