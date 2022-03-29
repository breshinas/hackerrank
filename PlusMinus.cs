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

    public static void plusMinus(List<int> arr)
    {
        double negativeCount=0.0,positiveCount=0.0,zeroCount=0.0;
        for(int i=0;i<arr.Count;i++){
            int num = arr[i];
            if(num<0){
                negativeCount++;
            }else if(num>0){
                positiveCount++;
            }else{
                zeroCount++;
            }
        }
        Console.WriteLine($"{positiveCount/arr.Count:0.000000}");
        Console.WriteLine($"{negativeCount/arr.Count:0.000000}");
        Console.WriteLine($"{zeroCount/arr.Count:0.000000}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
