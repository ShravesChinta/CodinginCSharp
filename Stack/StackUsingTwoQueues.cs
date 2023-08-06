using System;
namespace Basic_c_sharp_interview_prep
{
	public class StackUsingTwoQueues
	{
		public static void Main(string[] args)
		{
			StackUsingQueue<int> s = new StackUsingQueue<int>();
			s.Push(1);
			s.Push(2);
			s.Push(3);
			s.Push(4);
			s.Push(5);
			Console.WriteLine(s.Peek());
			Console.WriteLine(s.Pop());
			Console.WriteLine(s.Peek());



		}
	}
		public class StackUsingQueue<T>
		{
            Queue<T> q1 = new Queue<T>();
            Queue<T> q2 = new Queue<T>();

            public void Push(T a)
			{
				q2.Enqueue(a);

				while(q1.Count>0)
				{
					q2.Enqueue(q1.Dequeue());
				}

				Queue<T> q3 = new Queue<T>();

				q3 = q1;
				q1 = q2;
				q2 = q3;

			}

			public T Pop()
			{
				return q1.Dequeue();
			}

			public T Peek()
			{
				return q1.Peek();
	
		    }

		}
	}


