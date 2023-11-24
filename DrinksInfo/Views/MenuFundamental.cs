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

    public string GetUserResponse(string prompt)
    {
        while (true)
        {
            Console.WriteLine("write here >");
            Console.WriteLine(prompt);
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