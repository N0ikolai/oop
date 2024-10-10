using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(AccountType.Current);

            CommantInv invoker = new CommantInv();

            invoker.AddCommand(new CreateAccountCommand(account));

            invoker.ExecuteCommand();

        }
    }
}