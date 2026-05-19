namespace XOX_oyunu.Theme;

public static class AppTheme
{
    public static Color Background => Color.FromArgb(30, 30, 46);
    public static Color Surface => Color.FromArgb(42, 42, 62);
    public static Color Primary => Color.FromArgb(124, 108, 240);
    public static Color PrimaryHover => Color.FromArgb(144, 128, 255);
    public static Color AccentX => Color.FromArgb(255, 107, 138);
    public static Color AccentO => Color.FromArgb(78, 205, 196);
    public static Color Text => Color.FromArgb(234, 234, 240);
    public static Color Muted => Color.FromArgb(156, 163, 175);
    public static Color Border => Color.FromArgb(61, 61, 85);

    public static Font TitleFont => new("Segoe UI", 20F, FontStyle.Bold);
    public static Font SubtitleFont => new("Segoe UI", 15F, FontStyle.Regular);
    public static Font ButtonFont => new("Segoe UI", 14F, FontStyle.Bold);
    public static Font MenuButtonFont => new("Segoe UI", 18F, FontStyle.Bold);
    public static Font CellFont => new("Segoe UI", 28F, FontStyle.Bold);
    public static Font TurnFont => new("Segoe UI", 16F, FontStyle.Bold);
}
