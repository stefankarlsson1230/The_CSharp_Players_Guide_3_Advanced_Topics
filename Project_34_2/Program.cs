Random random = new Random();


Console.Write("Max random value: ");
double max = double.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.Write($"{random.NextDouble(max), -8:0.00}");
}

Console.WriteLine("\n");


string[] words = ["Blipp", "Blopp", "Tjohej", "Whatever"];
Console.WriteLine(random.NextString(words));

string coinToss = random.CoinFlip() ? "Head" : "Tail";

Console.WriteLine(coinToss);



// Typer
public static class RandomExtensions
{
    public static double NextDouble(this Random random, double max) => random.NextDouble() * max;
    public static string NextString(this Random random, params string[] values) => values[random.Next(values.Length)];
    public static bool CoinFlip(this Random random, double headProb = 0.5) => random.NextDouble() < headProb;
}

