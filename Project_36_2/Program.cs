// Math Delegate - Pass function to compute.

Console.WriteLine($"6 + 5 = {Compute(6, 5, Addition)}");
Console.WriteLine($"6 - 5 = {Compute(6, 5, Subtraction)}");
Console.WriteLine($"6 * 5 = {Compute(6, 5, Multiplication)}");


// Local functions
int Compute(int x, int y, Mathematics math) => math(x, y);

int Addition(int x, int y) => x + y;
int Subtraction(int x, int y) => x - y;
int Multiplication(int x, int y) => x * y;



// Delegate
public delegate int Mathematics(int x, int y);
