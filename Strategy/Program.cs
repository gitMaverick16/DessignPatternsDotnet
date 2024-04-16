// See https://aka.ms/new-console-template for more information
using Strategy.Example01;

//Example 01
TaxCalculator taxCalculator = new TaxCalculator(new USATaxCalculationStrategy());
decimal taxAmountUSA = taxCalculator.CalculateTaxAmount(1000);
Console.WriteLine("Taxes in the USA: $" + taxAmountUSA);
//Print Taxes in the USA: 100 

taxCalculator.SetCalculateTaxStrategy(new PeruTaxCalculationStrategy());
decimal taxAmountPeru = taxCalculator.CalculateTaxAmount(1000);
Console.WriteLine("Taxes in Perú: $" + taxAmountPeru);
//Print Taxes in Perú: 200 
