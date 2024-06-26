﻿// See https://aka.ms/new-console-template for more information
using Strategy.Example01;
using Strategy.Example02;

//Example 01
TaxCalculator taxCalculator = new TaxCalculator(new USATaxCalculationStrategy());
decimal taxAmountUSA = taxCalculator.CalculateTaxAmount(1000);
Console.WriteLine("Taxes in the USA: $" + taxAmountUSA);
//Print Taxes in the USA: 100 

taxCalculator.SetCalculateTaxStrategy(new PeruTaxCalculationStrategy());
decimal taxAmountPeru = taxCalculator.CalculateTaxAmount(1000);
Console.WriteLine("Taxes in Perú: $" + taxAmountPeru);
//Print Taxes in Perú: 200

//Example 02
FileCompressor fileCompressor = new FileCompressor(new ZipFileCompressionStrategy());
fileCompressor.CompressFile("file");

fileCompressor.SetCompressorStrategy(new RarFileCompressionStrategy());
fileCompressor.CompressFile("file");
