using Helpers;
using static System.Console;

namespace GameState;

// Classes

public class Game
{
    // Properties
    public Position Position { get; private set; }  // Current position
    public bool FountainActive { get; set; }
    public Map Map { get; }
    public int Arrows { get; private set; }


    // Constructor
    public Game(GameSize size)
    {
        FountainActive = false;
        Map = new Map(size);
        Position = Map.StartPos;
        Arrows = 5;
    }

    // Methods
    public void Move(Position pos)
    {
        Position.Row = Math.Clamp(pos.Row, 0, Map.RowSize - 1);
        Position.Col = Math.Clamp(pos.Col, 0, Map.ColSize - 1);
    }

    public bool IsAdjacent(RoomType roomType)     // Check if the specified roomtype is adjacent to the player position
    {
        Position pos1 = new Position(Math.Clamp(Position.Row - 1, 0, Map.RowSize - 1), Math.Clamp(Position.Col, 0, Map.ColSize - 1));
        Position pos2 = new Position(Math.Clamp(Position.Row - 1, 0, Map.RowSize - 1), Math.Clamp(Position.Col + 1, 0, Map.ColSize - 1));
        Position pos3 = new Position(Math.Clamp(Position.Row, 0, Map.RowSize - 1), Math.Clamp(Position.Col + 1, 0, Map.ColSize - 1));
        Position pos4 = new Position(Math.Clamp(Position.Row + 1, 0, Map.RowSize - 1), Math.Clamp(Position.Col + 1, 0, Map.ColSize - 1));
        Position pos5 = new Position(Math.Clamp(Position.Row + 1, 0, Map.RowSize - 1), Math.Clamp(Position.Col, 0, Map.ColSize - 1));
        Position pos6 = new Position(Math.Clamp(Position.Row + 1, 0, Map.RowSize - 1), Math.Clamp(Position.Col - 1, 0, Map.ColSize - 1));
        Position pos7 = new Position(Math.Clamp(Position.Row, 0, Map.RowSize - 1), Math.Clamp(Position.Col - 1, 0, Map.ColSize - 1));
        Position pos8 = new Position(Math.Clamp(Position.Row - 1, 0, Map.RowSize - 1), Math.Clamp(Position.Col - 1, 0, Map.ColSize - 1));

        Position[] positions = [pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8];

        foreach (Position pos in positions)
        {
            if (Map.GetRoom(pos).RoomType == roomType) return true;
        }

        return false;
    }

    public void Maelstrom()
    {
        // This will replace the current room with a maelstrom, which if you are unlucky could replace the entrance/fountain room.
        // I will ignore this flaw in this implementation
        Map.AddRoom(Position, RoomType.Empty);
        Map.AddRoom(new Position(Position.Row + 1, Position.Col - 2), RoomType.Maelstrom);
        Move(new Position(Position.Row - 1, Position.Col + 2));
    }

    public void ShootAt(Position pos)
    {
        if (Arrows == 0)
        {
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("You have no arrows left!");
            return;
        }

        // Make sure not to shoot outside of the map
        int row = Math.Clamp(pos.Row, 0, Map.RowSize - 1);
        int col = Math.Clamp(pos.Col, 0, Map.ColSize - 1);

        pos = new Position(row, col);
        Room room = Map.GetRoom(pos);

        if (room.RoomType == RoomType.Amarok || room.RoomType == RoomType.Maelstrom) Map.AddRoom(pos, RoomType.Empty);

        Arrows--;
    }
}

