using System;

namespace LinkedList_Problem    
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOpertion listOperation = new LinkListOpertion();
            listOperation.insert(56);
            listOperation.insert(30);
            listOperation.insert(70);
            listOperation.display();
        }
    }
    
}
