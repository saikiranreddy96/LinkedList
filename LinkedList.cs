using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        //Instance
        internal Node head;

        //Adding Data to LinkedList
        internal void Add(int data)
        {
            //Object of Node
            Node node = new Node(data);

            //Add Data
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

            Console.WriteLine("{0} inserted into the Linked List", node.data);
        }
        //UC2
        public void AddFirst(int NewData)
        {
            Node New_Node = new Node(NewData);
            New_Node.next = this.head;
            this.head = New_Node;
            Console.WriteLine("{0} Node added to the Linked-List.", New_Node.data);
        }
        internal void Display()
        {
            //Head is Null then List is empty otherwise print All data of Linked List
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
