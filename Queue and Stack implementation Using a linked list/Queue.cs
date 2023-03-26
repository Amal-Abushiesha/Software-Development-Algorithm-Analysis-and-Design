using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    internal class Queue
    {
        private Node front;
        private Node rear;
        private int counter = 0;
        public Queue()
        {
            this.front = this.rear =  null;
        }
        public void enqueue(int data)
        {
            Node newNode = new Node(data);
            if(front == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            counter++;
        }
        public int dequeue()
        {
            int keepData = front.data;
            if(front == null)
            {
                Console.WriteLine("Error! empty queue");
            }
            else
            {
                front = front.next;
                counter--;
            }
            if( front == null)
            {
                rear = null;
            }
            return keepData;
        }
        public bool isEmpty()
        {
            return front == null;
        }
        public void peek()
        {
            Console.WriteLine(front == null ? "Empty Queue!" : front.data);
        }
        public int size()
        {
            return counter;
        }

    }
}
