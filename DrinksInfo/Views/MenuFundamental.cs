using System.Runtime.CompilerServices;

public abstract class MenuFundamental
{
    public void PrintError(string error)
    {
        Console.WriteLine("There was an error: ");
        Console.WriteLine(error);
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    public void IrresolvableError(string error)
    {
        Console.WriteLine("There was a breaking error: ");
        Console.WriteLine(error);
        Environment.Exit(1);
    }

    public string GetUserResponse(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            Console.Write("write here >");
            string? response = Console.ReadLine(); 

            if (response == null || response == "")
            {
                this.InvalidInput();
                continue;
            }
            return response;
        }
    }

    public void InvalidInput(string prompt = "That was an invalid command")
    {
        Console.WriteLine(prompt);
        Console.WriteLine("Press any key to try again");
        Console.ReadKey();
    }

    public void SeperatorPrint()
    {
        Console.WriteLine("--------------------------------------------------------------------");
    }
}