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
// class Result
// {
// 	/*
// 	 * Complete the 'timeConversion' function below.
// 	 *
// 	 * The function is expected to return a STRING.
// 	 * The function accepts STRING s as parameter.
// 	 */
// 	public static string timeConversion(string s)
// 	{
// 		// A string to store military time
// 		string time;
// 		// The AM or PM section of the string
// 		string meridiem = s.Substring(s.Length - 2);
// 		// The current hour
// 		int hour = Int32.Parse(s.Substring(0, 2));
//
// 		if (meridiem == "AM")
// 		{
// 			// If the hour is twelve, it becomes midnight (00:00)
// 			// If the hour is less than twelve, it is unchanged
// 			time = hour == 12 ? $"00{s.Substring(2, 6)}" : s.Substring(0, 8);
// 		}
// 		else
// 		{
// 			// If the hour is not 12, add twelve so that it becomes military time
// 			// If the hour is 12, it is unchanged - it's noon in military time
// 			hour = hour != 12 ? 12 + hour : hour;
// 			time = $"{hour}{s.Substring(2, 6)}";
// 		}
//
// 		return time;
// 	}
// }
//
// class Solution
// {
// 	public static void Main(string[] args)
// 	{
// 		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//
// 		string s = Console.ReadLine();
//
// 		string result = Result.timeConversion(s);
//
// 		textWriter.WriteLine(result);
//
// 		textWriter.Flush();
// 		textWriter.Close();
// 	}
// }