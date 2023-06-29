Console.WriteLine("Задача 41--------------------");

Console.WriteLine("Enter a series of integer numbers separating each by pressing Enter. Then type q and press Enter.");

int[] userNumbers = Array.Empty<int>();
for (int i = 0; true; i++)
{
    string input = Console.ReadLine();
    if (input == "q") break;
    Array.Resize(ref userNumbers, i+1);
    userNumbers[i] = Convert.ToInt32(input);
}

int count = 0;
for (int i = 0; i < userNumbers.Length; i++)
{
    if (userNumbers[i] > 0) count++;
}

Console.WriteLine($"The number of positive integers is {count}");

Console.WriteLine("\nЗадача 43--------------------");

Console.WriteLine("\ny = k1 * x + b1\ny = k2 * x + b2\n");
Console.Write("Enter a value for b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value for k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value for b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value for k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"\nThe point of intersection of 'y = {k1}x + {b1}'\nwith 'y = {k2}x + {b2}' is ({x}; {y}).");

// x = (b2 - b1)/(k1 - k2)