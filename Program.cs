namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(AccountType.Current);

            Account account1 = new Account(AccountType.Saving);

            account.PrintAccountInfo();

            account1.PrintAccountInfo();

            account.CreateName();

            account.Deposit();

            account.AskUserIfHeWantsToPrintInfo();
        }
    }
}
