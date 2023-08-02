using FizzBuzz;

Console.Write("Enter a number: ");
var input = Console.ReadLine();

int number;
bool success = int.TryParse(input, out number);

if (!success || number < 1 || number > 100)
{
    Console.WriteLine("The number must between 1-100");
    Environment.Exit(0);
}

var output = new List<string>();
Enumerable.Range(1, number).ToList()
    .ForEach(n =>
    {
        var result = FizzBuzzService.Generate(n);
        output.Add(result != string.Empty ? result : "error");
    });
    
Console.WriteLine(string.Join(", ", output));
