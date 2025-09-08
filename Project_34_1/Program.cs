string input;
bool success;

// Int
int value1;

do
{
    Console.Write("Enter an integer: ");
    input = Console.ReadLine()!;
    success = int.TryParse(input, out value1);
    if (!success ) Console.WriteLine("That is NOT an integer!");
}
while (!success);

Console.WriteLine($"{value1} is an integer!");


// Double
double value2;

do
{
    Console.Write("Enter a number (decimal or integer) value: ");
    input = Console.ReadLine()!;
    success = double.TryParse(input, out value2);
    if (!success) Console.WriteLine("That is NOT a decimal or integer number!");
}
while (!success);

Console.WriteLine($"{value2} is a decimal/integer value!");


// Bool
bool value3;

do
{
    Console.Write("Enter a bool (true/false): ");
    input = Console.ReadLine()!;
    success = bool.TryParse(input, out value3);
    if (!success) Console.WriteLine("That is NOT a Boolean value!");
}
while (!success);

Console.WriteLine($"{value3} is a Boolean value!");

