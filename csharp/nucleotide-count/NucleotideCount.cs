using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> dna = new Dictionary<char, int>();
        dna.Add('A', 0);
        dna.Add('C', 0);
        dna.Add('G', 0);
        dna.Add('T', 0);

        string allowableLetters = "ACGT";


        foreach (char character in sequence)
        {
            if (!allowableLetters.Contains(character.ToString()))
            {
                throw new System.ArgumentException();
            }
            dna[character]++;
        }
    return dna;
    }
}