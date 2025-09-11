string input = String.Empty;
Sieve sieve = null;

// Choose delegate
while (input == String.Empty)
{
    Console.WriteLine("1. Even number, 2. Positive number, 3. Multiple of 10");
    Console.Write("Filter: ");
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            sieve = new(Even);
            break;
        case "2":
            sieve = new(Positive);
            break;
        case "3":
            sieve = new(MultiplesOf10);
            break;
        default:
            Console.WriteLine("Please choose 1,2 or 3");
            input = String.Empty;
            break;
    }   
}


// Use delegate
int number;
Console.WriteLine("Enter an integer");
while(true)
{
    Console.Write("Number: ");
    number = int.Parse(Console.ReadLine());

    if (sieve.IsGood(number)) Console.WriteLine($"{number} passed the test");
    else Console.WriteLine($"{number} did NOT pass the test");
}



// Local functions
bool Even(int n) => n % 2 == 0;
bool Positive(int n) => n >= 0;
bool MultiplesOf10(int n) => n % 10 == 0;


// Classes
public class Sieve
{
    private Func<int, bool> Del;

    public Sieve (Func<int, bool> del)
    {
        Del = del;
    }

    public bool IsGood(int number) 
    {  
        return Del(number); 
    }
}


