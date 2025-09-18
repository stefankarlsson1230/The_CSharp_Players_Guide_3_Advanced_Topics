// Basic Thread Start - Launch a thread that prints “Working…” 5 times.

Thread thread = new Thread(Working);
thread.Start();



// Local function
void Working()
{
    for(int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Working");
    }
}

