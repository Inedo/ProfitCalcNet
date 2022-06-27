// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using ProfiteCalcNet6.Console;

decimal? revenue = null;
decimal? expenses = null;

if (args.Length == 2)
{
    revenue = decimal.TryParse(args[0], out decimal r) ? (decimal?)r : null;
    expenses = decimal.TryParse(args[1], out decimal e) ? (decimal?)e : null;
}

if (revenue == null || expenses == null)
{
    revenue = PromptDecimal("Enter revenue: ");
    expenses = PromptDecimal("Enter expenses: ");
}

decimal profit = new AccountingCalculator().CalculateNet(revenue.Value, expenses.Value);

Console.WriteLine("Profit: " + profit.ToString("C2"));
Console.WriteLine("Profit JSON: " + JsonConvert.SerializeObject(profit));

static decimal PromptDecimal(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal d))
            return d;
        else
            Console.WriteLine("Please enter a valid decimal value.");
    }
}