// Guard Pattern - Match with conditions.

Dragon dragon1 = new(400, 20);
Dragon dragon2 = new(100, 5);
Dragon dragon3 = new(1000, 100);

Dragon[] dragons = new Dragon[] {dragon1, dragon2, dragon3};

foreach(Dragon dragon in dragons)
{
    string description = dragon switch
    {
        { HitPoints: > 500 } => "an ancient dragon",
        { HitPoints: > 300 } => "a really big dragon",
        _ => "a rather small dragon",
    };

    Console.WriteLine($"This is {description}");
}




// Classes
public class Dragon
{
    public int HitPoints { get; set; }
    public int Level { get; set; }

    public Dragon(int hitPoints, int level)
    {
        HitPoints = hitPoints;
        Level = level;
    }
}
