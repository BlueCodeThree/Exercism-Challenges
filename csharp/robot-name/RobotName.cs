using System;
using System.Collections.Generic;

public class Robot
{
    string _RobotName;
    static List<string> _NamesUsed = new List<string>();

    public Robot()
    {
         _RobotName = generateName();
    }

    public string Name
    {


        get
        {
            return _RobotName;
        }
    }

    public void Reset()
    {
        _RobotName = generateName();
    }

    public string generateName()
    {
        Random random = new Random();
        char randomChar1 = (char)random.Next('A','Z');
        char randomChar2 = (char)random.Next('A','Z');
        int num = random.Next(10);
        int num2 = random.Next(10);
        int num3 = random.Next(10);
        string tempName = randomChar1.ToString() + randomChar2.ToString() + num.ToString() + num2.ToString() + num3.ToString();
        if (_NamesUsed.Contains(tempName))
        {
            tempName = generateName();
        }
        _NamesUsed.Add(tempName);
        return tempName;
    }
}
