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
	 * Complete the 'lonelyinteger' function below.
	 *
	 * The function is expected to return an INTEGER.
	 * The function accepts INTEGER_ARRAY a as parameter.
	 */

	public static int lonelyinteger(List<int> a)
	{
		// Create a dictionary that stores number and their count in the given array a
		Dictionary<int, int> numberAndCount = new Dictionary<int, int>();

		foreach (int number in a)
		{
			// If it is in the dictionary, increase its occurrence count
			if (numberAndCount.ContainsKey(number))
			{
				numberAndCount[number]++;
			}
			else
			{
				// Else, add it to the dictionary
				numberAndCount.Add(number, 1);
			}
		}

		// Get the first key (number) with a value (occurrence count) equal to 1.
		return numberAndCount.First(kvp => kvp.Value == 1).Key;
	}

}

class Solution
{
	public static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine().Trim());

		List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

		int result = Result.lonelyinteger(a);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}