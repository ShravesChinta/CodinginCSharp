using System;
using System.Collections.Generic;
namespace Basic_c_sharp_interview_prep
{
	public class StackUsingFunction
	{
		public static void SUF()
		{
			Stack<int> stack = new Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			stack.Push(5);
			Console.WriteLine(stack.Peek());
			stack.Pop();
            Console.WriteLine(stack.Peek());

        }


	}
}

