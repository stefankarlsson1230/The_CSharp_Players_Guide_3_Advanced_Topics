// Thread Join - Wait for a worker thread to finish before continuing.

Thread thread = new(DoingStuff);
thread.Start();
thread.Join();

Console.WriteLine("The thread is now done!");


void DoingStuff()
{
    for(int i = 1; i <= 20; i++)
    {
        Console.WriteLine("I am doing stuff, wait until I'm done!");
    }
}