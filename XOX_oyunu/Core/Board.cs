namespace XOX_oyunu.Core;

public class Board
{
    private readonly char?[] _cells = new char?[9];

    public char? this[int index] => _cells[index];

    public char CurrentPlayer { get; private set; } = 'X';

    public bool IsCellEmpty(int index) => _cells[index] is null;

    public void Place(int index, char player)
    {
        _cells[index] = player;
    }

    public char?[] GetCells() => (char?[])_cells.Clone();

    public bool IsFull()
    {
        for (int i = 0; i < 9; i++)
        {
            if (_cells[i] is null)
                return false;
        }
        return true;
    }

    public void SwitchPlayer() => CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';

    public void Reset()
    {
        Array.Clear(_cells, 0, 9);
        CurrentPlayer = 'X';
    }
}
