using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    class Program
    {
        static void Main(string[] args)
        {

            Random range = new Random();
            BinarySearchTree myList = new BinarySearchTree();
            myList.Add(200);
            for (int index = 1; index <= 100; index++)
            {
                myList.Add(100 + range.Next(100));
                myList.Add(100 - range.Next(100));
            }
            myList.Search(150);
            myList.Search(100);
            myList.Search(200);
            myList.Search(10);
            myList.Search(50);
            myList.Search(20);
            Console.ReadLine();
            //;

            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //Node node5 = new Node(5);

            //myList.Add(node1);
            //myList.Add(node2);
            //myList.Add(node3);
            //myList.Add(node4);
            //myList.Add(node5);

            //myList.search(5);

            //Console.ReadLine()
        }
    }
}
