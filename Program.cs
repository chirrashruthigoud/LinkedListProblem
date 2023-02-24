
using LinkedListProblem;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.Add(56); // add a elemt at last postion Append is nothinf act as Add () method
            linked.Add(30);
            linked.Add(70);
            linked.Display();
            int a = linked.Search(30);
            Console.WriteLine("index position of element is :" + a);
            linked.InsertAtParticularPosition(a + 1, 40);
            linked.Display();
        }
    }
}