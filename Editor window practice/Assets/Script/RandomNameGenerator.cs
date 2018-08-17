using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNameGenerator
{
    static List<string> firstNames, lastNames;

    static RandomNameGenerator()
    {
        firstNames = new List<string>();
        #region FirstNames
        firstNames.Add("Harry");
        firstNames.Add("Hermione");
        firstNames.Add("Ron");
        firstNames.Add("Neville");
        firstNames.Add("Luna");
        firstNames.Add("Draco");
        #endregion

        lastNames = new List<string>();
        #region LastNames
        lastNames.Add("Potter");
        lastNames.Add("Granger");
        lastNames.Add("Weasley");
        lastNames.Add("Longbottom");
        lastNames.Add("Lovegood");
        lastNames.Add("Malfoy");
        #endregion
    }

    static string GetRandomFirstName()
    {
        int rand = Random.Range(0, firstNames.Count);
        return firstNames[rand];
    }
    static string GetRandomLastName()
    {
        int rand = Random.Range(0, lastNames.Count);
        return lastNames[rand];
    }

    public static string GetRandomName()
    {
        string str = "";
        str = GetRandomFirstName() + " " + GetRandomLastName();
        return str;
    }

}
