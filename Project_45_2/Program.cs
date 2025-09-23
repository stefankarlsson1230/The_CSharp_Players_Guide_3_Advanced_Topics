using System.Dynamic;

int counter = 1;
dynamic robot;
string? input;

// I am skipping a lot of input checks

while(true)
{
    robot = new ExpandoObject();
    robot.Id = counter;

    Console.WriteLine($"You are producing robot #{counter}");

    Console.Write("Do you want to name this robot? ");
    input = Console.ReadLine();
    if(input.ToLower() == "yes")
    {
        Console.Write("What is its name? ");
        robot.Name = Console.ReadLine();
    }

    Console.Write("Does this robot have a specific size? ");
    input = Console.ReadLine();
    if (input.ToLower() == "yes")
    {
        Console.Write("What is its height? ");
        robot.Height = int.Parse(Console.ReadLine());
        Console.Write("What is its width? ");
        robot.Width = int.Parse(Console.ReadLine());
    }

    Console.Write("Does this robot need to be a specific color? ");
    input = Console.ReadLine();
    if (input.ToLower() == "yes")
    {
        Console.Write("What color? ");
        robot.Color = Console.ReadLine();
    }

    foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot)
        Console.WriteLine($"{property.Key}: {property.Value}");


    counter++;
}

