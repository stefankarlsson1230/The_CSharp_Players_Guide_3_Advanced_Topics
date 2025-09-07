using Helpers;

namespace GameState;

// The map grid is counting from the top left corner [0,0] - Columns increases to the right, Rows increases downward
public class Map
{
    // Fields
    private Room[,] rooms;

    // Properties
    public int RowSize { get; }    // Number of Columns on the map
    public int ColSize { get; }    // Number of Rows on the map
    public Position StartPos { get; } // Position of Entrance


    // Constructor
    public Map(GameSize size) // Fixed map based on size
    {
        switch (size)
        {
            case GameSize.Small:
                RowSize = 4;
                ColSize = 4;
                break;
            case GameSize.Medium:
                RowSize = 6;
                ColSize = 6;
                break;
            case GameSize.Large:
                RowSize = 8;
                ColSize = 8;
                break;
        }

        // Add Empty rooms to all positions
        rooms = new Room[RowSize, ColSize];

        for (int i = 0; i < RowSize; i++)
        {
            for (int j = 0; j < ColSize; j++)
            {
                rooms[i, j] = new Room(RoomType.Empty);
            }
        }

        // Set startposition and add rooms based on size of map
        switch (size)
        {
            case GameSize.Small:
                StartPos = new Position(0, 0);
                AddRoom(new Position(0, 0), RoomType.Entrance);
                AddRoom(new Position(1, 2), RoomType.Fountain);
                AddRoom(new Position(3, 2), RoomType.Pit);
                AddRoom(new Position(2, 0), RoomType.Maelstrom);
                AddRoom(new Position(0, 3), RoomType.Amarok);
                break;
            case GameSize.Medium:
                StartPos = new Position(5, 0);
                AddRoom(new Position(5, 0), RoomType.Entrance);
                AddRoom(new Position(2, 4), RoomType.Fountain);
                AddRoom(new Position(0, 2), RoomType.Pit);
                AddRoom(new Position(3, 0), RoomType.Pit);
                AddRoom(new Position(2, 2), RoomType.Maelstrom);
                AddRoom(new Position(1, 0), RoomType.Amarok);
                AddRoom(new Position(5, 3), RoomType.Amarok);
                break;
            case GameSize.Large:
                StartPos = new Position(3, 7);
                AddRoom(new Position(3, 7), RoomType.Entrance);
                AddRoom(new Position(4, 2), RoomType.Fountain);
                AddRoom(new Position(0, 5), RoomType.Pit);
                AddRoom(new Position(3, 2), RoomType.Pit);
                AddRoom(new Position(4, 5), RoomType.Pit);
                AddRoom(new Position(7, 0), RoomType.Pit);
                AddRoom(new Position(1, 3), RoomType.Maelstrom);
                AddRoom(new Position(5, 5), RoomType.Maelstrom);
                AddRoom(new Position(1, 1), RoomType.Amarok);
                AddRoom(new Position(5, 2), RoomType.Amarok);
                AddRoom(new Position(7, 5), RoomType.Amarok);
                break;
        }
    }

    // Methods
    public void AddRoom(Position pos, RoomType roomType)
    {
        // Makes sure the room is placed on the map
        int row = Math.Clamp(pos.Row, 0, RowSize - 1);
        int col = Math.Clamp(pos.Col, 0, ColSize - 1);

        rooms[row, col] = new Room(roomType);
    }

    public Room GetRoom(Position pos)
    {
        return rooms[pos.Row, pos.Col];
    }

}

