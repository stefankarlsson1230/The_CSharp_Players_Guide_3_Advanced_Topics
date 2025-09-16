string? name;
int score = 0;

Console.Write("Name: ");
name = Console.ReadLine();

// Check for saved scores
if(File.Exists($"{name}.txt"))
{
    score = int.Parse(File.ReadAllText($"{name}.txt"));
}

// Pressing keys
while(true)
{
    Console.Clear();
    Console.WriteLine($"Score: {score}");
    Console.Write("Press a key! (Enter to save and exit) ");
    
    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.Enter) break;
    else score++;
}

// Saving score
File.WriteAllText($"{name}.txt", score.ToString());

