namespace DesignPatterns.Momento;

public class Player
{
    List<Position> positionMemory = new();
    Position.Piece piece = new();

    public void GoForward()
    {
        // roll dice
        var position = piece.GetPosition();
        positionMemory.Add(position);

        int n = new Random().Next(1, 6);
        piece.Move(n);
    }

    public void GoBack()
    {
        var position = positionMemory.Last();
        positionMemory.Remove(position);
        piece.SetPosition(position);
    }
}
