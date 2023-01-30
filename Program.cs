using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Codewars
{
	internal class Program
	{
		// Some solved kata`s from Codewars.com

		static void Main(string[] args)
		{

			int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
			var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
			string[] arr1 = new string[] { "2", "1", "3", "1", "4" };
			string[] arr2 = new string[] { "1" };
			string[] sout;
			sout = arrayDiff(arr1, arr2);

			Console.WriteLine(CreatePhoneNumber(m));
			Console.ReadLine();
		}

		// 8 kyu Even or Odd
		public static string EvenOrOdd(int number) => number % 2 != 0 ? "Odd" : "Even";

		static long GetAllOddSum(int[] intArray)
		=> (from i in intArray where i % 2 != 0 select (long)i).Sum();

		public static int FindSmallestInt(int[] args)
		=> (from int i in args orderby i ascending select i).First();

		public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
		{
			if (ClassPoints.Append(YourPoints).Average() < YourPoints) return true;
			else return false;
		}

		public int Min(int[] list)
		{
			return list.Min();
		}

		public int Max(int[] list)
		{
			return list.Max();
		}

		public static string CountSheep(int n)
		{
			string res = "";
			for (int i = 0; i < n; i++) res += String.Format("{0} sheep...", i + 1);
			return res;
			throw new NotImplementedException();
		}

		// Create a function which answers the question "Are you playing banjo?".
		//	If your name starts with the letter "R" or lower case "r", you are playing banjo!
		// The function takes a name as its only argument, and returns one of the following strings:
		// name + " plays banjo" 
		// name + " does not play banjo"
		// Names given are always valid strings.
		public static string AreYouPlayingBanjo(string name)
		{
			if (name[0].ToString().ToLower() == "r") return name + " plays banjo";
			else return name + " does not play banjo";

		}

		public static int summation(int num)
		{
			int res = 0;
			for (int i = 1; i <= num; i++) res += i;
			return res;
		}

		//public static string FindNeedle(object[] haystack)
		//{
		//	//return String.Format("found the needle at position {0}", haystack.ToList().FindIndex("needle"));
		//}

		public int CompareIt(string line1, string line2)
		{
			string[] tmp1;
			string[] tmp2;
			tmp1 = line1.Split(Convert.ToChar(" "));
			tmp2 = line2.Split(Convert.ToChar(" "));
			IEnumerable<uint> query1 = tmp1.OfType<uint>();
			IEnumerable<uint> query2 = tmp2.OfType<uint>();
			uint d1 = 0;
			uint d2 = 0;
			foreach (uint l1 in query1) d1 = l1;
			foreach (uint l2 in query2) d2 = l2;
			if (d2 < d1) return 0;
			else return 1;

		}

		//Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
		//It should remove all values from list a, which are present in list b keeping their order.
		//arrayDiff([1, 2],[1]) == [2]
		//If a value is present in b, all of its occurrences must be removed from the other:
		//arrayDiff([1, 2, 2, 2, 3],[2]) == [1,3]
		public static string[] arrayDiff(string[] arr1, string[] arr2)
		{
			foreach (string s in arr2)
			{
				arr1 = arr1.Where(a => a != s).ToArray();
			}
			return arr1;
		}

		public static string Solution(string str) => new string(str.Reverse().ToArray()).ToString();

		//6 kyu Create Phone Number
		public static string CreatePhoneNumber(int[] numbers)
		{
			return String.Format("({0}) {1}-{2}",
				String.Join("", numbers).Substring(0, 3),
				String.Join("", numbers).Substring(3, 3),
				String.Join("", numbers).Substring(6, 4));
		}


	}

}
