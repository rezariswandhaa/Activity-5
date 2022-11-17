using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    internal class Program
    {
        class Node
        {
            /*Node class represent the node of doubly linked list.
             * It consist of the information part and link to
             * its succeeding and preceeding node
             * int terms of next and previous nodes.*/
            public int rollNumber;
            public string name;
            public Node next;/*points to the succeeding node*/
            public Node prev;/*points to the preceeding node*/
        }
        class DoubleLinkedList
        {
            Node START;
            public DoubleLinkedList()
            {
                START = null;
            }
            public void addNode()/* Add a new code */
            {
                int rollNo;
                string nm;
                Console.Write("\nEnter the roll number of the student: ");
                rollNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the name of student: ");
                nm = Console.ReadLine();
                Node newnode = new Node();
                newnode.rollNumber = rollNo;
                newnode.name = nm;
                /*Checks if the list is empty*/
                if (START == null || rollNo <= START.rollNumber)
                {

                }
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
