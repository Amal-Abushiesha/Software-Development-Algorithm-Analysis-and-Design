using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_Assignment
{
    internal class queue
    {

        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        class Queue
        {
            private Node front, rear;
            public Queue()
            {
                front = rear = null;
            }

            public void Enqueue(int data)
            {
                Node temp = new Node(data);
                if (rear == null)
                {
                    front = rear = temp;
                    return;
                }
                rear.next = temp;
                rear = temp;
            }

            public void Dequeue()
            {
                if (front == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                Node temp = front;
                front = front.next;
                if (front == null)
                    rear = null;
            }

            public void PrintQueue()
            {
                if (front == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }


    }
}
