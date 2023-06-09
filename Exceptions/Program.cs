using Exceptions.Entities;
using System.Globalization;
using Exceptions.Entities.Exception;

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
        Console.Write("Enter amount for withdraw: ");
        double Amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        try
        {
            account.Withdraw(Amount);
            Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
    }
}