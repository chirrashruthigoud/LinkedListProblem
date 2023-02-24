
using LinkedListProblem;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.Append(56); 
            linked.Append(30);
            linked.Append(70);
            linked.Display();
            linked.InsertAtParticularPosition(2, 40);
            linked.Display();
            linked.RemoveFirstNode();
            linked.Display();
        }
    }
}