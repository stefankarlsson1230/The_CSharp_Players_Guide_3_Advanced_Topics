Direction direction = Direction.East;
Console.WriteLine((BlockOffset)direction);


// Types
public record BlockCoordinate(int Row, int Column)
{
    // Operators
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

    // Indexer
    public int this[int index]
    {
        get
        {
            if (index == 0) return Row;
            else return Column;
        }
    }


    // Methods
    public override string ToString()
    {
        return $"({Row}, {Column})";
    }
}

public record BlockOffset(int RowOffset, int ColumnOffset)
{
    public static implicit operator BlockOffset(Direction d)
    {
        return d switch
        {
            Direction.North => new BlockOffset(-1, 0),
            Direction.East => new BlockOffset(0, 1),
            Direction.South => new BlockOffset(1, 0),
            Direction.West => new BlockOffset(0, -1),
        };
    }


    public override string ToString()
    {
        return $"({RowOffset}, {ColumnOffset})";
    }
}

public enum Direction { North, East, South, West }
