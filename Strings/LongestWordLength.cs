using System;
namespace Basic_c_sharp_interview_prep
{
	public class LongestWordLength
	{
		public static void LongWordLen()
		{
			int longest_str_len = 0;
			string str = "hello this is my own world with hypothesis as the mainlowercharbut also as you";
			string[] input = str.Split(" ");
			
			if(input.Length==0 || input.Length==1)
			{
				longest_str_len = input.Length;
			}
			else {

				foreach(string a in input)
					{
					longest_str_len = Math.Max(longest_str_len,a.Length);
				}


			}

			Console.WriteLine($"The longest word in the string is '{longest_str_len}'");

		}
	}
}

