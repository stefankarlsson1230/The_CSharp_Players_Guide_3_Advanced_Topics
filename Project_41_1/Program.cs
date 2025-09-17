BlockCoordinate blockCoord = new BlockCoordinate(4, 3);
BlockOffset offset = new BlockOffset(2, 0);
Direction direction = Direction.East;

Console.WriteLine($"{blockCoord} + {offset} = {blockCoord + offset}");
Console.WriteLine($"{blockCoord} + {direction} = {blockCoord + direction}");


// ---------- Types ----------
// BlockCoordinate refers to a specific block’s location
// BlockOffset is for relative distances between blocks
// Direction specifies directions.
// Rows start at 0 at the north end of the city and get bigger as you go south, while columns
// start at 0 on the west end of the city and get bigger as you go east.

public record BlockCoordinate(int Row, int Column)
{
    public static BlockCoordinate operator +(BlockCoordinate a, BlockOffset b) => new BlockCoordinate(a.Row + b.RowOffset, a.Column + b.ColumnOffset);
    public static BlockCoordinate operator +(BlockOffset a, BlockCoordinate b) => new BlockCoordinate(a.RowOffset + b.Row, a.ColumnOffset + b.Column);

    public static BlockCoordinate operator +(BlockCoordinate a, Direction b)
    {
        return a + b switch
        {
            Direction.North => new BlockOffset(-1, 0),
            Direction.East => new BlockOffset(0, 1),
            Direction.South => new BlockOffset(1, 0),
            Direction.West => new BlockOffset(0, -1),
        };
    }
    public static BlockCoordinate operator +(Direction a, BlockCoordinate b) => b + a;


    public override string ToString()
    {
        return $"({Row}, {Column})";
    }
}

public record BlockOffset(int RowOffset, int ColumnOffset)
{
    public override string ToString()
    {
        return $"({RowOffset}, {ColumnOffset})";
    }
}

public enum Direction { North, East, South, West }
