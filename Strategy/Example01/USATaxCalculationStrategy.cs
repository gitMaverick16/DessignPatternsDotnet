namespace Strategy.Example01
{
    public class USATaxCalculationStrategy : ITaxCalculationStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            //All the logic to calculate taxes in the USA
            return amount * 0.10m;
        }
    }
}
