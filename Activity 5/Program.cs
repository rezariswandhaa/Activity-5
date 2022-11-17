﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List_Algorithm
{
    class Node
    {
        /* Node class represents the node of doubly linked list.
         * It consists of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of next and previous nodes,
         */
        public int rollNumber;
        public string name;
        public Node next;
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = (Console.ReadLine());
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;

            if (START == null || rollNo <= START.rollNumber)
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                newnode.next = START;
                if (START != null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;
            }

            Node previous, current;
            for (current = previous = START; current != null &&
                rollNo >= current.rollNumber; previous = current, current =
                current.next)
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }

            newnode.next = current;
            newnode.prev = previous;

            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
                return;
            }
            current.prev = newnode;
            previous.next = newnode;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current =START; current != null &&
                rollNo != current.rollNumber; previous = current,
                current = current.next) { }
            return (current != null);
        }

        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }

            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
       
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        

        static void Main(string[] args)
        {
            
            
        }
    }
}