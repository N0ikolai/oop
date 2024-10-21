public class Account
{
    private string id;
    private string name;
    private double balance;
    private AccountType type;
    private GenerationAccountID idGen = new GenerationAccountID();
    private Queue<BankTransaction> transactions = new Queue<BankTransaction>();
    public Account(AccountType type)
    {
        this.type = type;
        string getID = idGen.GenAccountID();
        name = "noname";
        id = getID;
        this.balance = 0;
    }

    public void Deposit()
    {
        Console.WriteLine("Do you wanna transfer money on you account?");
        Console.WriteLine("Enter 1 to say YES, or any key to say no");

        int input;

        if (int.TryParse(Console.ReadLine(), out input))
        {
            if (input == 1)
            {
                Console.WriteLine("Enter how much");
                if (double.TryParse(Console.ReadLine(), out double amount))
                    balance += amount;
                var transaction = new BankTransaction(amount);
                transactions.Enqueue(transaction);
                Console.WriteLine($"balanse id added to {amount}");
                Console.WriteLine($"{transaction.TransactionTime}");
            }
        }
    }

    public void Withdraw()
    {
        Console.WriteLine("How much do ya wanna withdraw?");
        Console.WriteLine("Enter 1 to say YES, or any key to say no");

        int input;

        if (int.TryParse(Console.ReadLine(), out input))
        {
            if (input == 1)
            {
                if (double.TryParse(Console.ReadLine(), out double amount))
                {
                    if (amount <= balance)
                    {
                        balance -= amount;
                        var transaction = new BankTransaction(amount);
                        transactions.Enqueue(transaction);
                        Console.WriteLine(balance);
                        Console.WriteLine($"{transaction.TransactionTime}");
                    }
                    else
                    {
                        Console.WriteLine("Cant be done.");
                    }
                }
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
        Console.WriteLine($"Account type: {type}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Account ID: {id}");
        Console.WriteLine($"Total balance: {balance}");
    }
}

