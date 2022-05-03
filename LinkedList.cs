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
                this.head = node;
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

        // UC4 Adding Data In Particular Position
        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} Node Inserted to the Linked-List.", node.data);
        }
        //UC5-To Delete First Element
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked-List is Empty.");
            }
            else
            {
                int delfirst = head.data;
                head = head.next;
                Console.WriteLine("\n{0} is Deleted from Linked-List.", delfirst);
            }
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
