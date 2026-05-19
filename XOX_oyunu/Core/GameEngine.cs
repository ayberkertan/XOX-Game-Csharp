namespace XOX_oyunu.Core;

public enum MoveResult
{
    Continue,
    Win,
    Draw
}

public class GameEngine
{
    private readonly Board _board = new();

    public int ScoreX { get; private set; }
    public int ScoreO { get; private set; }

    public char CurrentPlayer => _board.CurrentPlayer;

    public bool CanPlayAt(int index) => _board.IsCellEmpty(index);

    public MoveResult MakeMove(int index)
    {
        if (!_board.IsCellEmpty(index))
            return MoveResult.Continue;

        char player = _board.CurrentPlayer;
        _board.Place(index, player);

        char? winner = WinChecker.GetWinner(_board.GetCells());
        if (winner == 'X')
        {
            ScoreX++;
            _board.Reset();
            return MoveResult.Win;
        }

        if (winner == 'O')
        {
            ScoreO++;
            _board.Reset();
            return MoveResult.Win;
        }

        if (_board.IsFull())
        {
            _board.Reset();
            return MoveResult.Draw;
        }

        _board.SwitchPlayer();
        return MoveResult.Continue;
    }

    public char? GetCell(int index) => _board[index];

    public void ResetRound() => _board.Reset();
}
