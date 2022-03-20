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

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal minus = 0.0M;
        decimal positive = 0.0M;
        decimal zero = 0.0M;
        
        foreach(var item in arr) {
            if(item < 0) {
                minus++;
            }
            else if(item == 0) {
                zero++;
            }
            else {
                positive++;
            }
        }
        
        Console.WriteLine((positive / arr.Count).ToString("N6"));
        Console.WriteLine((minus / arr.Count).ToString("N6"));
        Console.WriteLine((zero / arr.Count).ToString("N6"));
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