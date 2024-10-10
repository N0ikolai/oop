using System;

public class PrintAccountInfoCommand : InterfaceCommand
{
    private Account account;

    public PrintAccountInfoCommand(Account account)
    {
        this.account = account;
    }

    public void Execute()
    {
        account.PrintAccountInfo();
    }
}
