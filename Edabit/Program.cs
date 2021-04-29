using System;
using System.Diagnostics;
using System.Linq;

namespace Edabit
{
    class Program
    {

		public static string Reverse(string str)
		{
			//Write a function that takes a string of one 
			//or more words as an argument and returns the same string, 
			//but with all five or more letter words reversed. 
			//Strings passed in will consist of only letters and spaces. 
			//Spaces will be included only when more than one word is present.

			string[] subs = str.Split(' ');

			for (int i = 0; i < subs.Length; i++)
			{
				if (subs[i].Length >= 5)
				{
					char[] array = subs[i].ToCharArray();
					Array.Reverse(array);
					subs[i] = new string(array);
				}
			}

			var result = String.Join(" ", subs);

			return result;

		}

		public static int[] ArrayOfMultiples(int num, int length)
		{
			int[] array = new int[length];

			//Debug.WriteLine(array[0]);

            for (int i = 0; i < length; i++)
            {
				//int j = i + 1;
				array[i] = num*(i+1);
            }

			//Debug.WriteLine(array[0]);

			return array;

		}

		public static int squareareasdifference(int radius)
		{
			int result = (int)Math.Pow(radius, 2);
			return result * 2;
		}

		public static string ReverseCase(string str)
		{
			char[] charstr = str.ToCharArray();

			for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str, i))
                {
					charstr[i] = Char.ToLower(str[i]);
                }

				if (Char.IsLower(str, i))
				{
					charstr[i] = Char.ToUpper(str[i]);
				}
			}
			string s = new string(charstr);
			return s;
		}

		public static double[] FindLargest(double[][] values)
		{
			//Create a function that takes an array of arrays with numbers. 
			//Return a new (single) array with the largest numbers of each.

			double[] array = new double[values.Length];

			for (int i = 0; i < values.Length; i++)
            {
				array[i] = values[i].Max();
			}

			return array;
		}

		public static bool CheckEquality(object a, object b)
		{
			if(a.Equals(b))
            {
				return true;
            }

			return false;
		}

		public static int collatz(int num)
		{
			int i;

            for (i = 0; num != 1; i++)
            {
                if (num % 2 == 0)
                {
					num /= 2;
                }
                else
                {
					num = (num * 3) + 1;
                }
            }

			return i;
		}

		public static string Maskify(string str)
		{
			int digitstomask;
			if (str.Length > 4)
			{
				digitstomask = str.Length - 4;
			}
            else
            {
				return str;
            }

			char[] array = str.ToCharArray();
			for (int i = 0; i < digitstomask; i++)
            {
				array[i] = '#';
            }
			string newstr = new string(array);

			return newstr;
		}

		static void Main(string[] args)
        {
			
        }
    }
}
