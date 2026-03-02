
public class GoodMorning
{
    /// <summary>
    /// dictionary for the Greeting method
    /// </summary>
    private static Dictionary<int, string> _greeting = new Dictionary<int, string> 
    {
        { 0,  "Good Night" },
        { 5,  "Good Morning" },
        { 12, "Good Day" },
        { 18, "Good Evening" },
        { 22, "Good Night" }
    }; 
    /// <summary>
    /// uses dictionary and finds the best greeting to return for the time of the day
    /// </summary>
    /// <param name="name">name to greet</param>
    /// <returns>returns greeting + name + the date and time</returns>
    public static string Greeting(string name)
    {
        int currentTime = DateTime.Now.Hour;
        
        // LINQ magic
        int BestGreeting = _greeting.Keys.Where(hour => hour <= currentTime).Max();
        // return the greeting + name + Date and time
        return _greeting[BestGreeting] + $" {name} the date and time is {DateTime.Now}";
    }
}