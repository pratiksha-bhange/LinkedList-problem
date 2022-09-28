﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Problem
{
    public class LinkListOpertion
    {

        public Node head;

        public void insert(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            if (head != null)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            else
            {
                head = newNode;
            }
        }

        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            Node temp = head;
            head = newNode;
            newNode.next = temp;
        }

        public void display()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}




