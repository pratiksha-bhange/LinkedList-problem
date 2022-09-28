using System;

namespace LinkedList_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOpertion listOperation = new LinkListOpertion();
            listOperation.append(56);
            listOperation.append(30);
            listOperation.append(70);
            listOperation.display();
        }
    }
}    
    
    

