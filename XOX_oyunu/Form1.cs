using XOX_oyunu.Core;
using XOX_oyunu.Theme;

namespace XOX_oyunu;

public partial class Form1 : Form
{
    private readonly GameEngine _engine = new();
    private readonly string _player1Name;
    private readonly string _player2Name;
    private readonly Button[] _cells;

    public Form1(string player1Name, string player2Name)
    {
        InitializeComponent();
        _player1Name = player1Name;
        _player2Name = player2Name;
        _cells = new[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

        UiStyler.ApplyForm(this, "XOX Oyunu");
        foreach (var cell in _cells)
            UiStyler.StyleCellButton(cell);

        UiStyler.StyleLabel(lblSkorX);
        UiStyler.StyleLabel(lblSkorO);
        UiStyler.StyleLabel(lblTurn);
        lblTurn.Font = AppTheme.TurnFont;

        lblSkorX.ForeColor = AppTheme.AccentX;
        lblSkorO.ForeColor = AppTheme.AccentO;

        UpdateScoreLabels();
        UpdateTurnLabel();
    }

    private void XOXtiklama(object sender, EventArgs e)
    {
        if (sender is not Button button)
            return;

        int index = Array.IndexOf(_cells, button);
        if (index < 0 || !_engine.CanPlayAt(index))
            return;

        char player = _engine.CurrentPlayer;
        MoveResult result = _engine.MakeMove(index);
        UiStyler.SetCellMark(button, player);

        switch (result)
        {
            case MoveResult.Win:
                ShowWinner(player);
                ResetBoardUi();
                UpdateScoreLabels();
                UpdateTurnLabel();
                return;

            case MoveResult.Draw:
                MessageBox.Show("Berabere! Yeni tur baþlýyor.", "XOX Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetBoardUi();
                UpdateTurnLabel();
                return;

            case MoveResult.Continue:
                UpdateTurnLabel();
                break;
        }
    }

    private void ShowWinner(char winner)
    {
        string name = winner == 'X' ? _player1Name : _player2Name;
        MessageBox.Show($"{name} Kazandýn!", "XOX Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ResetBoardUi()
    {
        foreach (var cell in _cells)
            UiStyler.ResetCellButton(cell);
    }

    private void UpdateScoreLabels()
    {
        lblSkorX.Text = $"{_player1Name} (X): {_engine.ScoreX}";
        lblSkorO.Text = $"{_player2Name} (O): {_engine.ScoreO}";
    }

    private void UpdateTurnLabel()
    {
        char current = _engine.CurrentPlayer;
        string name = current == 'X' ? _player1Name : _player2Name;
        lblTurn.Text = $"Sýra: {name} ({current})";
        lblTurn.ForeColor = current == 'X' ? AppTheme.AccentX : AppTheme.AccentO;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
