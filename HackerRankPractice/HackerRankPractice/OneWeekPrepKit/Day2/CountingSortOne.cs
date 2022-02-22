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
	 * Complete the 'countingSort' function below.
	 *
	 * The function is expected to return an INTEGER_ARRAY.
	 * The function accepts INTEGER_ARRAY arr as parameter.
	 */

	public static List<int> countingSort(List<int> arr)
	{
		// NOTE: The question does NOT want a counting-sorted array. It wants the frequency array.
		// Create an array to store frequencies in. Question specifies that it will ALWAYS come with lenght 100
		int[] frequency = new int[100];

		for (int index = 0; index < arr.Count; index++)
		{
			// Add each number to its corresponding index in the frequency array.
			frequency[arr[index]]++;
		}

		return frequency.ToList();
	}
}

class Solution
{
	public static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine().Trim());

		List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
		                       .ToList();

		List<int> result = Result.countingSort(arr);

		textWriter.WriteLine(String.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}
}