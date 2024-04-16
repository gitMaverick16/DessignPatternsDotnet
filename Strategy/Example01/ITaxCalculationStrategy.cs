namespace Strategy.Example01
{
    public interface ITaxCalculationStrategy
    {
        decimal CalculateTax(decimal amount);
    }
}
