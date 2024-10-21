using System;

public class GenerationAccountID
{
    private Random random = new Random();

    public string GenAccountID()
    {
        int id = random.Next(0,1000000);
        return id.ToString("D6"); 
    }
}
