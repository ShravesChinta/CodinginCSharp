using System;
namespace Basic_c_sharp_interview_prep
{
	public class CharacterOccurenceCount
	{
		public static void Main(String[] args)
		{
			string s = "Hello how are you doing";
			char c = 'e';

			Console.WriteLine(CharCount(s, c));
		}

		public static int CharCount(string s, char c)
		{
			int count = 0;
			for(int i=0;i<s.Length;i++)
			{
				if (s[i] == c)
					count++;
			}
			return count;
		}
	}
}
