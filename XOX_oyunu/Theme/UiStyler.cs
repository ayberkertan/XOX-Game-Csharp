namespace XOX_oyunu.Theme;

public static class UiStyler
{
    public static void ApplyForm(Form form, string title)
    {
        form.Text = title;
        form.BackColor = AppTheme.Background;
        form.ForeColor = AppTheme.Text;
        form.FormBorderStyle = FormBorderStyle.FixedSingle;
        form.MaximizeBox = false;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.Font = AppTheme.SubtitleFont;
        form.BackgroundImage = null;
    }

    public static void StyleLabel(Label label, bool muted = false)
    {
        label.ForeColor = muted ? AppTheme.Muted : AppTheme.Text;
        label.BackColor = Color.Transparent;
    }

    public static void StylePrimaryButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = AppTheme.Primary;
        button.ForeColor = AppTheme.Text;
        button.Font = AppTheme.MenuButtonFont;
        button.Cursor = Cursors.Hand;
        button.UseVisualStyleBackColor = false;
        button.BackgroundImage = null;

        var normal = AppTheme.Primary;
        var hover = AppTheme.PrimaryHover;

        button.MouseEnter += (_, _) => button.BackColor = hover;
        button.MouseLeave += (_, _) => button.BackColor = normal;
    }

    public static void StyleSecondaryButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 1;
        button.FlatAppearance.BorderColor = AppTheme.Border;
        button.BackColor = AppTheme.Surface;
        button.ForeColor = AppTheme.Text;
        button.Font = AppTheme.MenuButtonFont;
        button.Cursor = Cursors.Hand;
        button.UseVisualStyleBackColor = false;
        button.BackgroundImage = null;

        var normal = AppTheme.Surface;
        var hover = AppTheme.Border;

        button.MouseEnter += (_, _) => button.BackColor = hover;
        button.MouseLeave += (_, _) => button.BackColor = normal;
    }

    public static void StyleTextBox(TextBox textBox)
    {
        textBox.BackColor = AppTheme.Surface;
        textBox.ForeColor = AppTheme.Text;
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.Font = AppTheme.SubtitleFont;
    }

    public static void StyleCellButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 1;
        button.FlatAppearance.BorderColor = AppTheme.Border;
        button.BackColor = AppTheme.Surface;
        button.ForeColor = AppTheme.Text;
        button.Font = AppTheme.CellFont;
        button.Cursor = Cursors.Hand;
        button.UseVisualStyleBackColor = false;
        button.Text = string.Empty;
        button.Margin = new Padding(4);

        button.MouseEnter += (_, _) =>
        {
            if (string.IsNullOrEmpty(button.Text))
                button.BackColor = AppTheme.Border;
        };
        button.MouseLeave += (_, _) =>
        {
            if (string.IsNullOrEmpty(button.Text))
                button.BackColor = AppTheme.Surface;
        };
    }

    public static void SetCellMark(Button button, char mark)
    {
        button.Text = mark.ToString();
        button.Enabled = false;
        button.ForeColor = mark == 'X' ? AppTheme.AccentX : AppTheme.AccentO;
        button.BackColor = AppTheme.Surface;
    }

    public static void ResetCellButton(Button button)
    {
        button.Text = string.Empty;
        button.Enabled = true;
        button.ForeColor = AppTheme.Text;
        button.BackColor = AppTheme.Surface;
    }
}
