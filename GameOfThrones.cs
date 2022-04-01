using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static string gameOfThrones(string s)
    {
        var map = new Dictionary<char, int>();
        var counter = 0;
        var oddCount = 0;
        foreach (var t in s)
        {
            if(!map.ContainsKey(t))
                map[t] = 1;
            else {
                map[t] += 1;
            }
        }
        
        foreach(var pair in map.AsEnumerable()) {
            if(pair.Value %2 == 1)
                oddCount++;
            if(oddCount == 2)
                return "NO";
        }
        if(s.Length%2 == 1 && oddCount == 1)
            return "YES";
        else if(s.Length%2 == 0 && oddCount == 1)
            return "NO";
        else
            return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
