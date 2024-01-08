namespace AgeToDays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Este é um aplicativo que transforma anos em dias");
        int inputYears = Convert.ToInt32(Console.ReadLine());
        int outputDays = AgeConvert.AgeintoDays(inputYears);
        Console.WriteLine($"Result: [{outputDays}] days!");
    }
}

public static class AgeConvert
{
    public static int AgeintoDays (int years)
    {
        return 365 * years;
    }
}