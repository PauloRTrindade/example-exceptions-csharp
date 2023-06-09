using Exceptions.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter account data:");
        Console.Write("Number: ");
        int Number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string Holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Account account = new Account(Number, Holder, Balance, WithdrawLimit);

        Console.WriteLine();
        Console.WriteLine(account);
    }
}