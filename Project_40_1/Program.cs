Potion potion = Potion.Water;
Ingredient ingredient = Ingredient.Nothing;
string? input = "bad";

while(true)
{
    // Current potion
    Console.Clear();
    Console.WriteLine($"Current Potion: {potion}");

    // Continue or complete the potion
    input = "bad";
    while (input == "bad")
    {
        Console.Write("Do you want to complete the potion(1) or add another ingredient(2)? ");
        input = Console.ReadLine();

        switch (input)
        {
            case "1":
                return;
            case "2":
                break;
            default:
                input = "bad";
                break;
        }
    }

    // Choose ingredient
    input = "bad";

    while (input == "bad")
    {
        Console.Write("Choose ingredient: Dragon Breath, Eyeshine Gem, Shadow Glass, Snake Venom or Stardust: ");
        input = Console.ReadLine()!.ToLower();

        switch (input)
        {
            case "dragon breath":
                ingredient = Ingredient.DragonBreath;
                break;
            case "eyeshine gem":
                ingredient = Ingredient.EyeshineGem;
                break;
            case "shadow glass":
                ingredient = Ingredient.ShadowGlass;
                break;
            case "snake venom":
                ingredient = Ingredient.SnakeVenom;
                break;
            case "stardust":
                ingredient = Ingredient.Stardust;
                break;
            default:
                input = "bad";
                break;
        }
    }

    // Adding ingredient
    potion = (ingredient, potion) switch
    {
        (Ingredient.Stardust, Potion.Water) => Potion.Elixir, 
        (Ingredient.SnakeVenom, Potion.Elixir) => Potion.Poison,
        (Ingredient.DragonBreath, Potion.Elixir) => Potion.Flying,
        (Ingredient.ShadowGlass, Potion.Elixir) => Potion.Invisibility,
        (Ingredient.EyeshineGem, Potion.Elixir) => Potion.NightSight,
        (Ingredient.ShadowGlass, Potion.NightSight) => Potion.CloudyBrew,
        (Ingredient.EyeshineGem, Potion.Invisibility) => Potion.CloudyBrew,
        (Ingredient.Stardust, Potion.CloudyBrew) => Potion.Wraith,
        _ => Potion.Ruined,    
    };

    if(potion is Potion.Ruined)
    {
        Console.WriteLine("Your potion is ruined! You have to start over with water. Press any key to continue.");
        potion = Potion.Water;
        Console.ReadKey();
    }

}



// Enums
enum Potion { CloudyBrew, Elixir, Flying, Invisibility, NightSight, Poison, Ruined, Water, Wraith  }
enum Ingredient  { DragonBreath, EyeshineGem, Nothing, ShadowGlass, SnakeVenom, Stardust }
