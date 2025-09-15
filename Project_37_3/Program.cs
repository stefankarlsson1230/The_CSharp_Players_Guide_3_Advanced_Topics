// Alarm Clock - Fire event on timeout.

Console.Write("Seconds: ");
int seconds = int.Parse(Console.ReadLine());

Timer timer = new(seconds);
Alarm alarm = new(timer);
timer.Run();



// Classes
public class Timer
{
    private int seconds;
    public event Action Alarm;

    public Timer(int sec)
    {
        seconds = sec;
    }

    public void Run()
    {
        Thread.Sleep(seconds * 1000);
        Alarm?.Invoke();
    }
}


public class Alarm
{
    public Alarm(Timer timer)
    {
        timer.Alarm += SoundAlarm;
    }

    private void SoundAlarm()
    {
        Console.WriteLine("Ding! Ding! Ding!");
    }
}

