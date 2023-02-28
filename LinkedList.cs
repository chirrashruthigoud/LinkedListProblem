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
        public void Add(int data)
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");

                }
            }
            Console.WriteLine("After Inserting value in Linkedlist ");


            return head;
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {

                return null;
            }
            Console.WriteLine("When Remove first element");
            this.head = this.head.next;
            return this.head;
        }

        
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Console.WriteLine("When Remove Last element");
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {

                    return count;

                }
                node = node.next;
                count++;
            }
            return count;
        }

        public void del()
        {
            int value = 40;
            Node temp = this.head;
            int count = 0;

            while (temp != null)
            {
                Console.WriteLine(temp.data);

                temp = temp.next;
                if (temp.data == value)
                {
                    temp = temp.next.next;
                }
                count++;
            }
            Console.WriteLine("Total count : {0} ", count);
        }

    }
}