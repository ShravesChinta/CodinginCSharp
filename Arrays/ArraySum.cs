using System;
namespace Basic_c_sharp_interview_prep
{
	public class ArraySum
	{

		public static void SumOfArray()
		{
			Console.WriteLine("Enter the length of the array to be created");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arraysum = new int[n];
			int sum = 0;
			Console.WriteLine("Now lets enter the numbers of the array");
			for(int i=0;i<n;i++)
			{
				arraysum[i]= Convert.ToInt32(Console.ReadLine());
				sum = sum + arraysum[i];
            }

			Console.WriteLine($"The sum of the array is {sum} ");
		}
	}
}

