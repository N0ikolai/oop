namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(AccountType.Current);

            account.PrintAccountInfo();

            account.CreateName();

            account.Deposit();

            account.Withdraw();

            account.AskUserIfHeWantsToPrintInfo();
        }
    }
}
