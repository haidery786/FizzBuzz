using FizzBuzz.Console.Services;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    private static IServiceProvider _serviceProvider;
    static void Main(string[] args)
    {
        RegisterServices();

        string numInput = string.Empty;
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        // Ask the user to type the first number.
        Console.WriteLine("Type a number, and then press Enter");
        numInput = Console.ReadLine();

        int cleanNumber = 0;
        while (!int.TryParse(numInput, out cleanNumber))
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
            numInput = Console.ReadLine();
        }

        var calculatorService = _serviceProvider.GetService<ICalculatorService>();

        var result = calculatorService.Calculator(Convert.ToInt32(numInput));

        Console.WriteLine($"Result {result}");

        Console.ReadKey();

        DisposeServices();
    }

    private static void RegisterServices()
    {
        var services = new ServiceCollection();

        services.AddScoped<ICalculatorService, CalculatorService>();

        _serviceProvider = services.BuildServiceProvider();
    }

    private static void DisposeServices()
    {
        if (_serviceProvider == null)
        {
            return;
        }

        if (_serviceProvider is IDisposable)
        {
            ((IDisposable)_serviceProvider).Dispose();
        }
    }
}