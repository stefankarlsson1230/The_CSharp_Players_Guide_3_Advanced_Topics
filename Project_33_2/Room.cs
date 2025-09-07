using Helpers;

namespace GameState;
public class Room
{
    public string Description { get; set; }
    public RoomType RoomType { get; }
    public ConsoleColor Color { get; }


    public Room(RoomType roomType)
    {
        RoomType = roomType;

        Description = roomType switch
        {
            RoomType.Amarok => "You are devoured by a giant, rotting, wolflike Amarok! \nGame Over!",
            RoomType.Empty => "",
            RoomType.Entrance => "You see light coming from the cavern entrance.",
            RoomType.Fountain => "You hear water dripping in this room. The Fountain of Objects is here!",
            RoomType.Maelstrom => "You are suddenly swept away by a Maelstrom!",
            RoomType.Pit => "You stumble down a bottomless pit! \nGame over!",
        };

        Color = roomType switch
        {
            RoomType.Amarok => ConsoleColor.Red,
            RoomType.Empty => ConsoleColor.Gray,
            RoomType.Entrance => ConsoleColor.Yellow,
            RoomType.Fountain => ConsoleColor.Blue,
            RoomType.Maelstrom => ConsoleColor.Green,
            RoomType.Pit => ConsoleColor.DarkGray,
        };
    }
}

