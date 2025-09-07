using GameState;
using Helpers;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        // Setup
        string input = "";
        Game game = null;

        while (input == "")
        {
            Write("Do you want a small (4x4), medium (6x6) or large (8x8) world? ");
            input = ReadLine()!.ToLower();

            switch (input)
            {
                case "small":
                    game = new(GameSize.Small);
                    break;
                case "medium":
                    game = new(GameSize.Medium);
                    break;
                case "large":
                    game = new(GameSize.Large);
                    break;
                default:
                    input = "";
                    break;
            }
        }

        Clear();


        // Instructions
        int width = Console.WindowWidth;
        string lineDivider = new string('-', width);

        ForegroundColor = ConsoleColor.White;
        WriteLine("You enter the Cavern of Objects, a maze of rooms filled with dangerous \npits in search of the Fountain of Objects.");
        WriteLine("Light is visible only in the entrance, and no other light is seen anywhere\nin the caverns.");
        WriteLine("You must navigate the Caverns with your other senses.");
        WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
        WriteLine("- Look out for pits. You will feel a breeze if a pit is in an adjacent room. \nIf you enter a room with a pit, you will die.");
        WriteLine("- Maelstroms are violent forces of sentient wind. Entering a room with one \ncould transport you to any other location in the caverns. You will be able \nto hear their growling and groaning in nearby rooms.");
        WriteLine("- Amaroks roam the caverns. Encountering one is certain death, but you can \nsmell their rotten stench in nearby rooms.");
        WriteLine("- You carry with you a bow and a quiver of arrows. You can use them to shoot \nmonsters in the caverns but be warned: you have a limited supply.");
        WriteLine("- Enter \"help\" to get a list of commands.");


        // Gameloop
        Room currentRoom;

        while (true)
        {
            currentRoom = game!.Map.GetRoom(game.Position);

            ForegroundColor = ConsoleColor.Gray;
            WriteLine(lineDivider);
            WriteLine($"You are in the room at (Row = {game.Position.Row}, Column = {game.Position.Col}) Arrows left: {game.Arrows}");

            // check for win condition
            if (currentRoom.RoomType == RoomType.Entrance && game.FountainActive)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
                WriteLine("You win!");
                break;
            }

            // Check for loose condition
            if (currentRoom.RoomType == RoomType.Pit)
            {
                ForegroundColor = currentRoom.Color;
                WriteLine(currentRoom.Description);
                break;
            }
            else if (currentRoom.RoomType == RoomType.Amarok)
            {
                ForegroundColor = currentRoom.Color;
                WriteLine(currentRoom.Description);
                break;
            }

            // Descriptions of current room
            if (currentRoom.RoomType != RoomType.Empty)
            {
                ForegroundColor = currentRoom.Color;
                WriteLine(currentRoom.Description);

                if (currentRoom.RoomType == RoomType.Maelstrom)
                {
                    game.Maelstrom();
                    continue;
                }
            }

            //  Check for adjacent pits
            if (game.IsAdjacent(RoomType.Pit))
            {
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("You feel a draft. There is a pit in a nearby room.");
            }

            // Check for adjacent Maelstrom
            if (game.IsAdjacent(RoomType.Maelstrom))
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("You hear the growling and groaning of a maelstrom nearby.");
            }

            // Check for adjacent Amaroks
            if (game.IsAdjacent(RoomType.Amarok))
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("You can smell the rotten stench of an amarok in a nearby room.");
            }

            // Player input
            ForegroundColor = ConsoleColor.Gray;
            Write("What do you want to do? ");
            ForegroundColor = ConsoleColor.Cyan;
            input = ReadLine()!.ToLower();

            switch (input)
            {
                case "help":
                    WriteLine(lineDivider);
                    WriteLine("help\nmove north\nmove south\nmove east\nmove west\nshoot north\nshoot south\nshoot east\nshoot west\nenable fountain");
                    break;
                case "move north":
                    game.Move(new Position(game.Position.Row - 1, game.Position.Col));
                    break;
                case "move south":
                    game.Move(new Position(game.Position.Row + 1, game.Position.Col));
                    break;
                case "move east":
                    game.Move(new Position(game.Position.Row, game.Position.Col + 1));
                    break;
                case "move west":
                    game.Move(new Position(game.Position.Row, game.Position.Col - 1));
                    break;
                case "shoot north":
                    game.ShootAt(new Position(game.Position.Row - 1, game.Position.Col));
                    break;
                case "shoot south":
                    game.ShootAt(new Position(game.Position.Row + 1, game.Position.Col));
                    break;
                case "shoot east":
                    game.ShootAt(new Position(game.Position.Row, game.Position.Col + 1));
                    break;
                case "shoot west":
                    game.ShootAt(new Position(game.Position.Row, game.Position.Col - 1));
                    break;
                case "enable fountain":
                    if (currentRoom.RoomType == RoomType.Fountain)
                    {
                        game.FountainActive = true;
                        currentRoom.Description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
                    }
                    else
                    {
                        WriteLine("It has no effect!");
                    }
                    break;
                default:
                    break;
            }

        }

        ForegroundColor = ConsoleColor.Gray;    // Reset to standard color
    }
}

