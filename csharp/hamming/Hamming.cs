using System;
using System.Collections.Generic;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length == 0 && secondStrand.Length == 0)
        {
            return 0;
        }
        if (firstStrand.Length == 0 || secondStrand.Length == 0)
        {
            throw new System.ArgumentException();
        }
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new System.ArgumentException();
        }

        List<char> firstStrandList = new List<char>(  firstStrand );
        List<char> secondStrandList = new List<char>(  secondStrand );
        int differenceCount = 0;
        for (int i = 0; i < firstStrandList.Count; i++)
        {
            if (firstStrandList[i] != secondStrandList[i])
            {
                differenceCount += 1;
            }
        }
        return differenceCount;
    }
}