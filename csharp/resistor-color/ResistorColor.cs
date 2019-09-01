using System;

public static class ResistorColor
{
    private static string[] ResistorColours = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {
        return Array.IndexOf(ResistorColours, color);
    }

    public static string[] Colors()
    {
        return ResistorColours;
    }
}