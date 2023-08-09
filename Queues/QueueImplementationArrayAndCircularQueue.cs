using System;
namespace Basic_c_sharp_interview_prep
{
	public class QueueUsingArray
	{
		int[] QueueA;
		int capacity;
		int rear;
		int front;
		public QueueUsingArray(int size)
		{
			capacity = size;
			QueueA = new int[capacity];
			rear = front = -1;
		}

		public void Enqueue(int ele)
		{
			if(isFill())
			{
				Console.WriteLine("The queue is full, cannot insert anymore");
			}
			else if(isEmpty())
			{
				front = rear = 0;
			}
			else {
				rear++;
			}
			try
			{
				QueueA[rear] = ele;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
		}

		public bool isEmpty()
		{
			if (front == -1 && rear == -1)
				return true;

			return false;
		}

		public bool isFill()
		{
			if (rear == capacity)
				return true;

			return false;

		}

		public int Dequeue()
		{
			if(isEmpty())
			{

				Console.WriteLine("The queue is empty, nothing to dequeue");
				return -1;

			}

            int ele = QueueA[front];
            if (front==rear)
			{
				front = rear = -1;
			}
			else {
				front = front + 1;
			}

			return ele;

		}

		public int Peek()
		{
			return QueueA[front];
		}

	}

	public class Queuecircular
	{
        int[] QueueA;
        int capacity;
        int rear;
        int front;
        public Queuecircular(int size)
        {
            capacity = size;
            QueueA = new int[capacity];
            rear = front = -1;
        }

        public void Enqueue(int ele)
        {
            if ((rear+1)%capacity==front)
            {
                Console.WriteLine("The queue is full, cannot insert anymore");
            }
            else if (isEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity;
            }
            try
            {
                QueueA[rear] = ele;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public bool isEmpty()
        {
            if (front == -1 && rear == -1)
                return true;

            return false;
        }

        public bool isFill()
        {
            if (rear == capacity)
                return true;

            return false;

        }

        public int Dequeue()
        {
            if (isEmpty())
            {

                Console.WriteLine("The queue is empty, nothing to dequeue");
                return -1;

            }

            int ele = QueueA[front];
            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1)%capacity;
            }

            return ele;

        }

        public int Peek()
        {
            return QueueA[front];
        }

    }
public class QueueArray {

		public static void Main(string[] args)
		{
			QueueUsingArray q = new QueueUsingArray(10);
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
            q.Enqueue(11);
			Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Queuecircular qc = new Queuecircular(10);
            qc.Enqueue(1);
            qc.Enqueue(2);
            qc.Enqueue(3);
            qc.Enqueue(4);
            qc.Enqueue(5);
            qc.Enqueue(6);
            qc.Enqueue(7);
            qc.Enqueue(8);
            qc.Enqueue(9);
            qc.Enqueue(10);
            qc.Enqueue(11);
            Console.WriteLine(qc.Dequeue());
            Console.WriteLine(qc.Dequeue());
            qc.Enqueue(11);
            Console.WriteLine(qc.Peek());
            Console.WriteLine(qc.Dequeue());
            Console.WriteLine(qc.Dequeue());
        }

	}
}

