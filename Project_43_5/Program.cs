// Race Condition Demo - Show how two threads can corrupt a shared counter.

// The number should always be 0 when read and "Bang!!" never be printed!

Counter counter = new();

Thread thread1 = new(DoStuff);
Thread thread2 = new(DoStuff);

thread1.Start(counter);
thread2.Start(counter);



// --------------------------------
void DoStuff(object obj)
{
    Counter counter = (Counter)obj; 

    while(true)
    {
        if(counter.Number != 0) Console.WriteLine("BANG!!");
        counter.SetNumber();
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