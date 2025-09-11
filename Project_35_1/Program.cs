Random random = new Random();

int badCookie = random.Next(10);
int choice;
string currentPlayer = "Player 1";
List<int> usedNumbers = new List<int>();
string divider = new string('-', Console.WindowWidth);

try
{
    do
    {
        Console.WriteLine(divider);
        Console.Write($"{currentPlayer} guess a number (0-9): ");
        choice = int.Parse(Console.ReadLine());
        while (usedNumbers.Contains(choice))
        {
            Console.WriteLine("That number have already been choosen.");
            Console.Write($"{currentPlayer} guess a number (0-9): ");
            choice = int.Parse(Console.ReadLine());
        }

        if (choice == badCookie) throw new OatmealRaisinException("You got the bad cookie!");

        usedNumbers.Add(choice);
        currentPlayer = currentPlayer == "Player 1" ? "Player 2" : "Player 1";
    }
    while (true);
}
catch(OatmealRaisinException e)
{
    string winner = currentPlayer == "Player 1" ? "Player 2" : "Player 1";

    Console.WriteLine($"Congratulations {winner} You are the winner!");
    Console.WriteLine($"Sorry {currentPlayer}, {e.Message}");
}




// Types
public class OatmealRaisinException: Exception
{
    public OatmealRaisinException(string message) : base (message) {}
}



