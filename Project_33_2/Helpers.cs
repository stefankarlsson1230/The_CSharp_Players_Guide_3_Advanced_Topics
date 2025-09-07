namespace Helpers;

    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }


    // Enums
    public enum RoomType { Amarok, Empty, Entrance, Fountain, Maelstrom, Pit }
    public enum GameSize { Small, Medium, Large }


