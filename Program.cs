using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome To The Linked List Program");

            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            //Pop means delete
            linkedList.PopLast();
        
            Console.WriteLine("The elements in linked list are : ");
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
