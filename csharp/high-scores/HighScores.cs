using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> _highScores;
    public HighScores(List<int> list)
    {
        _highScores = list;
    }

    public List<int> Scores()
    {
        return _highScores;
    }

    public int Latest()
    {
        return _highScores[_highScores.Count - 1];
    }

    public int PersonalBest()
    {
        return _highScores.Max();
    }

    public List<int> PersonalTopThree()
    {
        // List<int> personalTopThreeScores = new List<int> {};
        // personalTopThreeScores.Add(_highScores.Max());
        // _highScores.Remove(_highScores.Max());
        // if (_highScores.Count > 0)
        // {
        //     personalTopThreeScores.Add(_highScores.Max());
        //     _highScores.Remove(_highScores.Max());
        // }
        // if (_highScores.Count > 0)
        // {
        //     personalTopThreeScores.Add(_highScores.Max());
        //     _highScores.Remove(_highScores.Max());
        // }
        // return personalTopThreeScores;

        return _highScores.OrderByDescending(x => x).Take(3).ToList();
    }
}