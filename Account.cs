using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

public class Account
{
    private string id;
    private string name;
    private double balance;
    private AccountType type;
    private GenerationAccountID idGen = new GenerationAccountID();

    public Account(AccountType type)
    {
        this.type = type;
        this.id = idGen.GenIDAccount();
        name = "noname";
        this.balance = 0;
    }

    public void CreateName()
    {
        Console.WriteLine("What's your name");
        name = Console.ReadLine();
    }

    public void Deposit()
    {
        Console.WriteLine("Enter how much do ya wanna amount to deposite:");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            balance += amount;
            Console.WriteLine($"Balance updated : {balance}");
        }
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine($"Account type: {type}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Account ID: {id}");
        Console.WriteLine($"Total balance: {balance}");
    }

}
