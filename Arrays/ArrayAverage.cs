using System;
namespace Basic_c_sharp_interview_prep
{
	public class ArrayAverage
	{

		public static void DoubleArrayAvg()
		{
			Console.WriteLine("Enter the lucky number");
			double num = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($" the number user provided is {num}");

			double[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			double sum = 0.0;
			foreach(double a in array1)
			{
				sum = sum + a;

			}

			Console.WriteLine($"The Average of the double Array is {sum/array1.Length}");
		}
	}
}

