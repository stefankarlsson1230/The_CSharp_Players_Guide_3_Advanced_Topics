// Params Total - Sum an array of values.

Console.WriteLine($"8 + 8 + 9 = {Sum(8, 8, 9)}");
Console.WriteLine($"1 + 1 = {Sum(1, 1)}");
Console.WriteLine($"10 - 5 + 12 - 100 + 67= {Sum(10, -5, 12, -100, 67)}");


// Local functions
int Sum(params int[] values)
{
    int sum = 0;

    foreach(int x in values) sum += x;

    return sum;
}