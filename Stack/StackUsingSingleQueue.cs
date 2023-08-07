using System;
namespace Basic_c_sharp_interview_prep
{
	public class StackUsingSingleQueue
	{
		public static void Main(string[] args)
		{
			QueueStack<int> qs = new QueueStack<int>();
			qs.push(10);
			qs.push(20);
			qs.push(30);
			qs.push(40);
			qs.push(50);
			qs.push(60);
			Console.WriteLine(qs.Peek());

			Console.WriteLine(qs.Pop());
            Console.WriteLine(qs.Peek());
        }

	}
}

	public class QueueStack<T>
	{
		Queue<T> q = new Queue<T>();

		public T Pop()
		{
            return q.Dequeue();
        }

		public void push(T ele)
		{
			q.Enqueue(ele);
			for(int i=0;i<q.Count-1;i++)
			{
				q.Enqueue(q.Dequeue());
			}

		}

		public T Peek()
		{

			return q.Peek();
		}
	}

