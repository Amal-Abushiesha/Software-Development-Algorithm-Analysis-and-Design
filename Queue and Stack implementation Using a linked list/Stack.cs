using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListStack;

namespace LinkedListStack
{
    internal class Stack
    {
     

        private Node top;
        private int counter = 0;
        public Stack()
        {
            this.top = null;
        }

            //Create a new node with the value to be inserted.
            //If the stack is empty, set the next of the new node to null.
            //If the stack is not empty, set the next of the new node to top.
            //Finally, increment the top to point to the new node.
        public void push(int data)
        {
            Node newNode = new Node(data);

            if(top == null) //stack is empty
            {
                newNode.next = null;
            }
            else //there are elements in the stack
            {
                newNode.next = top; //the next of the new element now points to the top of the stack
            }
            counter++;
            top = newNode; //update the top to the inserted node

        }
            //If the stack is empty, terminate the method as it is stack underflow.
            //If the stack is not empty, increment the top to point to the next node.
            //Hence the element pointed to by the top earlier is now removed.
        public int pop()
        {
            int returnValue = top.data;
            if (top == null)
            {
                Console.WriteLine("Error Stack is empty!");
            }
            else
            {
                top = top.next;
                counter--;
            }
            return returnValue;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public void peek()
        {
            Console.WriteLine(top == null? "Empty Stack" : top.data);
        }
        public int size()
        {
            return counter;
        }
    }
}
