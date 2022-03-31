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

    const string numbers = "0123456789";
    const string lower_case = "abcdefghijklmnopqrstuvwxyz";
    const string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string special_characters = "!@#$%^&*()-+";

    public static int minimumNumber(int n, string password)
    {
        var res = 0;
        var numCount = 0;
        var lowerCount = 0;
        var upperCount = 0;
        var specCount = 0;
        foreach(var x in password){
            if (numbers.Contains(x))
                numCount++;
            else if (special_characters.Contains(x))
                specCount++;
            else if (lower_case.Contains(x))
                lowerCount++;
            else if (upper_case.Contains(x))
                upperCount++;
        }
        // Its length is at least 6
        if (password.Length < 6)
            res = 6 - password.Length;
        var additionalSymbols = 0;
        // It contains at least one digit.
        if (numCount == 0)
            additionalSymbols++;
        // It contains at least one lowercase English character.
        if (specCount == 0)
            additionalSymbols++;
        // It contains at least one uppercase English character.
        if (lowerCount == 0)
            additionalSymbols++;
        // It contains at least one special character. 
        if (upperCount == 0)
            additionalSymbols++;
        
        return Math.Max(res, additionalSymbols);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
