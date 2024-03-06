// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");








int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};

static void PrintNubers(string title, IEnumerable<int> numbers)
{
    Console.WriteLine();
    Console.Write($"{title}: [");
    foreach (int number in numbers)
    {
        Console.Write($" {number}");
    }
    Console.WriteLine($" ]");
    Console.WriteLine();
}

static bool IsEven(int number) => number % 2 == 0;
static bool IsOdd(int number) => !IsEven(number);

PrintNubers("Numbers", numbers);
PrintNubers("Even No", numbers.Where(x=> IsEven(x)));
PrintNubers("Odd No", numbers.Where(x => IsOdd(x)));