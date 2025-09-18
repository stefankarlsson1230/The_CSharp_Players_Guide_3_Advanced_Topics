// Thread-Safe Counter - Fix the above using lock.

// The number should always be 0 when read and "Bang!!" never be printed! --- This should now be fixed with the lock!

Counter counter = new();

Thread thread1 = new(DoStuff);
Thread thread2 = new(DoStuff);

thread1.Start(counter);
thread2.Start(counter);



// --------------------------------
void DoStuff(object obj)
{
    Counter counter = (Counter)obj;

    while (true)
    {
        lock (counter)
        {
            if (counter.Number != 0) Console.WriteLine("BANG!!");
            counter.SetNumber();
        }
    }
}


public class Counter
{
    public int Number { get; set; } = 0;

    public void SetNumber()
    {
        Number++;
        Number++;
        Number++;
        Number--;
        Number--;
        Number--;
    }
}