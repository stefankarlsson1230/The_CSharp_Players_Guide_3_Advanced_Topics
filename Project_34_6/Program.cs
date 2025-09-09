// ref Swap Use ref to swap two variables.

int a = 5;
int b = 1;

Console.WriteLine($"a = {a}, b = {b}");
Swap(ref a, ref b);
Console.WriteLine($"Swapped: a = {a}, b = {b}");


// Local functions
void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

