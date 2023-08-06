using System;
namespace Basic_c_sharp_interview_prep
{
	public class RemoveDuplicatesfromArray
	{
		public static void RDFA()
		{
			int[] array1 = { 5, 3, 8, 2, 5, 1, 8, 4 };
			int[] new_array = new int[array1.Length];
			//Two ways to solve it.
			int index = 0;
			Array.Sort(array1);
			new_array[index++] = array1[0];
			for(int i=1;i<array1.Length;i++)
			{
				if (array1[i] == array1[i-1])
				{
					continue;
				}
				new_array[index++] = array1[i];
			}

			for(int i=0;i<new_array.Length;i++)
			{
				Console.Write(new_array[i] + " ");
			}

			//Using HashSet and List

			HashSet<int> hs = new HashSet<int>();
			List<int> l=new List<int>();

			foreach(int a in array1)
			{
				if(hs.Add(a))
				{
					l.Add(a);
				}
			}

			int[] nodup = l.ToArray();
            for (int i = 0; i <nodup.Length; i++)
            {
                Console.Write(nodup[i] + " ");
            }
        }
		
	}
}

