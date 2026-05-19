using XOX_oyunu.Theme;

namespace XOX_oyunu;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
        UiStyler.ApplyForm(this, "XOX Oyunu - Ana Menü");
        UiStyler.StyleLabel(label1);
        label1.Font = AppTheme.TitleFont;
        UiStyler.StylePrimaryButton(button1);
        UiStyler.StyleSecondaryButton(button2);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form3 form3 = new();
        form3.Show();
        Hide();
    }
}
