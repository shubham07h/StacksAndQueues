using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class Stack_Ex
    {
        Node top;
        public void Stack_in()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", data);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty deletion is not possible");
            }
            else
            {
                Console.WriteLine("Values popped is {0}", top.data);
                top = top.Next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0} is in the top of stack and it is peeked value", top.data);

            }
        }
    }
}