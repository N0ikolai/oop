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
   
    public Account (AccountType type)
    {
        this.type = type;
        string getID = idGen.GenAccountID();
        name = "noname";
        id = getID;
        this.balance = 0;
    }

    public void Deposit()
    {
        Console.WriteLine("Do you wanna transfer money on you account?" +
           " \n Enter 1 to say YES \n Enter any key to say NO");

        string inputString = Console.ReadLine();
        int input;

        if (int.TryParse(inputString, out input))
        {
            if (input == 1)
            {
                Console.WriteLine("Enter how much");
                double amount = Convert.ToDouble(Console.ReadLine());
                balance += amount;
                Console.WriteLine($"balanse id added to {amount}");
            }
        }
    }

    public string CreateName()
    {
        Console.WriteLine("What's ya name");
        name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cound not be empty! \n try again!");
            return CreateName();
        }

        return name;
    }
    public void AskUserIfHeWantsToPrintInfo()
    {
        Console.WriteLine("Do you wanna print info on the screen?" +
            " \n Enter 1 to say YES \n Enter any key to say NO");

        string inputString = Console.ReadLine();
        int input;

        if (int.TryParse(inputString, out input))
        {
            if (input == 1)
            {
                PrintAccountInfo();
            }
            else
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }
        }
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine($"Account type : {type},\n Name : {name} ,\n Account id : {id},\n Total balanse : {balance}");
    }
}

