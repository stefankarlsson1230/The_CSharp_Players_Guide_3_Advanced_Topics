// Event Firing - Simulate button click.

Button button = new Button();

Console.WriteLine("Press a key");

Looping.Run();


// Classes
public static class Looping
{
    public static event Action? ButtonClick;

    public static void Run()
    {
        while (true)
        {
            Console.ReadKey(true);
            ButtonClick?.Invoke();
        }
    }
}


public class Button
{
    public Button()
    {
        Looping.ButtonClick += ButtonClicked;
    }

    private void ButtonClicked()
    {
        Console.WriteLine("You pressed a button!");
    }
}


