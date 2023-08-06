using System;
namespace Basic_c_sharp_interview_prep
{
	public class StackUsingArrays
	{
		public static void Main(string[] args)
		{
			Stack<int> s = new Stack<int>(10);
			s.push(1);
			s.push(2);
			s.push(3);
			s.push(4);
			s.push(5);
			s.push(6);
            Console.WriteLine(s.peek());
            Console.WriteLine(s.pop());
			s.push(7);
            Console.WriteLine(s.pop());
			s.push(8);
			s.push(9);
			s.push(10);
			s.push(11);
			s.push(12);
			s.push(13);
			Console.WriteLine(s.top);
        }
	}
	public class Stack<T>
	{
		T[] stacka;
		public int top;

		public Stack(int capacity)
		{
			stacka = new T[capacity];
			top = -1;
		}
		public bool IsEmpty()
		{

			return top == -1;
		}

		public bool IsFull()
		{
			return top == stacka.Length - 1;
		}

		public void push(T ele)
		{
			if(IsFull())
			{
				Console.WriteLine("The stack is full");
				return;
			}
			else {
				top++;
				stacka[top] = ele;

			}
			
			
		}
		public T pop()
		{
			T poppedel = stacka[top--];
			return poppedel;

		}
		public T peek()
		{
			return stacka[top];
		}

	}
}

