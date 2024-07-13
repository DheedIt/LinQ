namespace LinQ.Features;
internal class CustomComparer : IComparer<string>
{
    public int Compare(string? firstElement, string? secondElement)
    {
        int x = firstElement?.Length ?? 0;
        int y = secondElement?.Length ?? 0;
        return x - y;
    }
}

