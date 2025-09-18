RecentNumbers numbers = new();
Console.WriteLine("Press any key!");

Thread thread1 = new Thread(NumberGenerator);
thread1.Start(numbers);

while(true)
{
    Console.ReadKey(true);
    lock (numbers)
    {
        if (numbers.Current == numbers.Previous) Console.WriteLine("YES! There was a repeat!");
        else Console.WriteLine($"Sorry, {numbers.Current} and {numbers.Previous} are not the same.");
    }
}



// Local functions 
void NumberGenerator(object obj)
{
    RecentNumbers numbers = (RecentNumbers)obj;

    Random random = new Random();

    while(true)
    {
        lock (numbers)
        {
            numbers.Previous = numbers.Current;
            numbers.Current = random.Next(10);
            Console.WriteLine(numbers.Current);
        }
        Thread.Sleep(1000);
    }
}


// Types
public class RecentNumbers
{
    public int Current { get; set; }
    public int Previous { get; set; }

    public RecentNumbers()
    {
        Random random = new Random();

        Current = random.Next(10);
        Previous = random.Next(10);
    }
}

