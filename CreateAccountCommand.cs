using System;

public class CreateAccountCommand : InterfaceCommand
{
    private Account account;

    public CreateAccountCommand(Account account)
    {
         this.account = account;
    }

    public void Execute()
    {
        account.CreateName();
    }

}
