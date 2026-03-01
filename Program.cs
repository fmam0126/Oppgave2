namespace Oppgave2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        if (name == null)
        {
            throw new Exception("name Cant be null");
        }
        Console.WriteLine(GoodMorning.Greeting(name));
    }
}
