// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;
//
// namespace HackerRankPractice.OneWeekPrepKit
// {
// 	class Result
// 	{
// 		/*
// 		 * Complete the 'plusMinus' function below.
// 		 *
// 		 * The function accepts INTEGER_ARRAY arr as parameter.
// 		 */
// 		public static void plusMinus(List<int> arr)
// 		{
// 			// The obvious approach is the best one for this problem.
// 			int positiveNumbers = 0;
// 			int negativeNumbers = 0;
// 			int neutralNumbers = 0;
//
// 			foreach (int integer in arr)
// 			{
// 				if (integer >= 1)
// 				{
// 					positiveNumbers++;
// 					continue;
// 				}
// 				if (integer <= -1)
// 				{
// 					negativeNumbers++;
// 					continue;
// 				}
// 				
// 				neutralNumbers++;
// 			}
// 			
// 			Console.WriteLine((positiveNumbers / (double)arr.Count).ToString("N6"));
// 			Console.WriteLine((negativeNumbers / (double)arr.Count).ToString("N6"));
// 			Console.WriteLine((neutralNumbers / (double)arr.Count).ToString("N6"));
// 		}
// 	}
//
// 	class Solution
// 	{
// 		public static void Main(string[] args)
// 		{
// 			int n = Convert.ToInt32(Console.ReadLine().Trim());
//
// 			List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//
// 			Result.plusMinus(arr);
// 		}
// 	}
// }