using System;

public static class ResistorColor
{
    private static string[] ResistorColours = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    // recommended by D to not use lambda functions here
    public static int ColorCode(string color) => Array.IndexOf(ResistorColours, color);

    public static string[] Colors() => ResistorColours;
}