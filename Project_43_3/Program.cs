// Multi-Printer - Launch two threads to print different characters simultaneously.

Thread thread1 = new(RedText);
Thread thread2 = new(GreenText);

thread1.Start();
thread2.Start();


void RedText()
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
    }
}

void GreenText()
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Green");
    }
}

