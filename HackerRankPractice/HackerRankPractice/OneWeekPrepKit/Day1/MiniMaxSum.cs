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
	 * Complete the 'miniMaxSum' function below.
	 *
	 * The function accepts INTEGER_ARRAY arr as parameter.
	 */
	public static void miniMaxSum(List<int> arr)
	{
		// Sort the array in ascending order
		arr.Sort();
		
		// Take the first four elements (the smallest)
		// Aggregate starting with 0L. Use Aggregate and not Sum because Sum will return an int.
		long min = arr.Take(4).Aggregate(0L, (sum, element) => sum + element);
		// Take the last four elements (the largest)
		long max = arr.Skip(1).Take(4).Aggregate(0L, (sum, element) => sum + element);

		Console.WriteLine(min + " " + max);
	}

}

class Solution
{
	public static void Main(string[] args)
	{

		List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

		Result.miniMaxSum(arr);
	}
}