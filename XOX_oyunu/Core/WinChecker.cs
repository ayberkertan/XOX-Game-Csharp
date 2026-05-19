namespace XOX_oyunu.Core;

public static class WinChecker
{
    private static readonly int[][] Lines =
    {
        new[] { 0, 1, 2 },
        new[] { 3, 4, 5 },
        new[] { 6, 7, 8 },
        new[] { 0, 3, 6 },
        new[] { 1, 4, 7 },
        new[] { 2, 5, 8 },
        new[] { 0, 4, 8 },
        new[] { 2, 4, 6 }
    };

    public static char? GetWinner(char?[] cells)
    {
        foreach (var line in Lines)
        {
            char? a = cells[line[0]];
            char? b = cells[line[1]];
            char? c = cells[line[2]];

            if (a is not null && a == b && b == c)
                return a;
        }

        return null;
    }
}
