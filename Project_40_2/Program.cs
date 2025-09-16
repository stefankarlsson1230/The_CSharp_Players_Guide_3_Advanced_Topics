string description = string.Empty;

Tree[] trees = new Tree[] {new Oak(), new Pine(), new Tree() };

foreach (Tree tree in trees)
{
    description = tree switch
    {
        Oak => "This is an oak.",
        Pine => "This is a Pine.",
        Tree => "This is just some tree.",
    };

    Console.WriteLine(description);
}


// Classes
public record Tree;
public record Oak: Tree;
public record Pine: Tree;

