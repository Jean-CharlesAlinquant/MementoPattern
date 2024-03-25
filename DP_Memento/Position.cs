namespace DesignPatterns.Momento;

public struct Position
{
    public Position(int cell)
    {
        Cell = cell;
        Console.WriteLine($"Starting At: {Cell}");
    }

    private int Cell { get; set; }

    public class Piece
    {
        private Position _position = new Position(0);

        public void Move(int n)
        {
            _position.Cell += n;
            Console.WriteLine($"Moving To: {_position.Cell}");
        }

        public Position GetPosition()
        {
            return new Position() { Cell = _position.Cell };
        }

        public void SetPosition(Position p)
        {
            _position.Cell = p.Cell;
            Console.WriteLine($"Going Back To: {_position.Cell}");
        }
    }
}