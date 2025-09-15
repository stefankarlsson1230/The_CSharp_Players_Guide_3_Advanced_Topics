CharberryTree tree = new CharberryTree();
Notifier notifier = new Notifier(tree);
Harvester harvester = new Harvester(tree);

while (true)
    tree.MaybeGrow();



// Classes
public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe { get; set; }
    public event Action? Ripened;   
    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripened?.Invoke();
        }
    }
}


public class Notifier
{
    public Notifier(CharberryTree tree)
    {
        tree.Ripened += Handler;
    }

    private void Handler() => Console.WriteLine("A charberry fruit has ripened!");
}


public class Harvester
{
    private CharberryTree _tree;

    public Harvester(CharberryTree tree)
    {
        _tree = tree;
        tree.Ripened += Handler;
    }

    private void Handler()
    {
        _tree.Ripe = false;
        Console.WriteLine("The tree has been harvested!");
    }
}
