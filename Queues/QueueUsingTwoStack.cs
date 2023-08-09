using System;
namespace Basic_c_sharp_interview_prep
{
	public class QueueUsingTwoStack
	{
		Stack<int> s1 = new Stack<int>();
		Stack<int> s2 = new Stack<int>();

	    public void Enqueue(int a)
		{
			s1.Push(a);
		}

		public int Top()
		{
			if (s2.Count > 0)
				return s2.Peek();
			while(s1.Count>0)
			{
				s2.Push(s1.Pop());
			}
			return s2.Peek();
		}

		public int Dequeue()
		{
			if (s2.Count > 0)
				return s2.Pop();

			while(s1.Count>0)
			{
                s2.Push(s1.Pop());
            }
			return s2.Pop();

        }

	}
	public class QueueStack
	{

		public static void Main(string[] args)
		{
			QueueUsingTwoStack q = new QueueUsingTwoStack();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Enqueue(8);
            q.Enqueue(9);
            q.Enqueue(10);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            q.Enqueue(11);
            q.Enqueue(12);
            q.Enqueue(13);
			Console.WriteLine(q.Top())
;

        }
	}
}

