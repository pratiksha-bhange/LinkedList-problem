using System;

namespace LinkedList_Problem    
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOpertion listOperation = new LinkListOpertion();
            listOperation.Add(70);
            listOperation.Add(30);
            listOperation.Add(56);
            listOperation.display();;
        }
    }
    
}
