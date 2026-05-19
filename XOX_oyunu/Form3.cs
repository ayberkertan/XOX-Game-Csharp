using XOX_oyunu.Theme;

namespace XOX_oyunu;

public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
        UiStyler.ApplyForm(this, "XOX Oyunu - Oyuncu Girişi");
        UiStyler.StyleLabel(label1);
        UiStyler.StyleLabel(label2);
        UiStyler.StyleLabel(label3);
        label3.Font = AppTheme.TitleFont;
        UiStyler.StyleTextBox(txtOyuncu1);
        UiStyler.StyleTextBox(txtOyuncu2);
        UiStyler.StylePrimaryButton(btnBasla);
    }

    private void btnBasla_Click(object sender, EventArgs e)
    {
        string name1 = txtOyuncu1.Text.Trim();
        string name2 = txtOyuncu2.Text.Trim();

        if (string.IsNullOrWhiteSpace(name1) || string.IsNullOrWhiteSpace(name2))
        {
            MessageBox.Show("Lütfen her iki oyuncu için de isim girin.", "XOX Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.Equals(name1, name2, StringComparison.OrdinalIgnoreCase))
        {
            MessageBox.Show("Oyuncu isimleri farklı olmalıdır.", "XOX Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Form1 gameForm = new(name1, name2);
        gameForm.Show();
        Hide();
    }
}
