// Custom EventArgs - Send extra data with event.
// Just printing the same random number through three different handlers


NumberSpammer spammer = new();
MessagePrinter printer1 = new(spammer);
MessagePrinter printer2 = new(spammer);
MessagePrinter printer3 = new(spammer);

spammer.Spam();



// Classes
public class NumberSpammer
{
    public delegate void MyEventHandler(int x);
    public event MyEventHandler? Handlers;
    private Random random;

    public NumberSpammer()
    {
        random = new Random();
    }

    public void Spam()
    {
        Handlers?.Invoke(random.Next(100));
    }
}


public class MessagePrinter
{
    public MessagePrinter(NumberSpammer spammer)
    {
        spammer.Handlers += Print;
    }

    public void Print(int x)
    {
        Console.WriteLine(x);
    }

}