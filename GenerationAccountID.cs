using System;

public class GenerationAccountID
{
    private static Random random = new Random();

    public string GenIDAccount()
    {
        return random.Next(100000,999999).ToString();

    }
}