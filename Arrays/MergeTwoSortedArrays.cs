using System;
namespace Basic_c_sharp_interview_prep
{
	public class MergeTwoSortedArray
	{
		public static void mergeSortedArray()
		{
            int[] arr1 = { 1, 3, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8, 10 };

			int[] merged = new int[arr1.Length + arr2.Length];

			int i, j, k;
			i = j = k = 0;

			while(i<arr1.Length && j<arr2.Length)
			{
				if (arr1[i] < arr2[j])
				{
					merged[k++] = arr1[i++];
				}

				else {
                    merged[k++] = arr2[j++];
                }

			}

			while(i<arr1.Length)
			{
                merged[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                merged[k++] = arr2[j++];
            }

			for(i=0;i<merged.Length;i++)
			{
				Console.Write(merged[i] + " , ");
			}

        }
	}
}

