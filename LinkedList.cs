using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node head;

        public void add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;

            }
            Console.WriteLine("{0} insert into linked List ", node.data);

        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;

            }
            Console.WriteLine("After storing in LinkedList value!!");
            while (temp != null)
            {

                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

