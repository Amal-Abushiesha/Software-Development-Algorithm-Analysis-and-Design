using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_Assignment
{
    internal class stack
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public class Stack
        {
            private Node top;

            public Stack()
            {
                this.top = null;
            }

            public void Push(int data)
            {
                Node newNode = new Node(data);

                if (top == null)
                {
                    top = newNode;
                    return;
                }

                newNode.next = top;
                top = newNode;
            }

            public int Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }

                int data = top.data;
                top = top.next;
                return data;
            }

            public int Peek()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }

                return top.data;
            }

            public bool IsEmpty()
            {
                return top == null;
            }

            public void PrintStack()
            {
                Node current = top;

                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }

        }




    }

}
