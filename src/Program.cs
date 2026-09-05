// Build: 15f7f3399b702fcdfbaffbd3300a4a65
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
