﻿using System;
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
            BinarySearchTree myList = new BinarySearchTree();

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            myList.Add(node1);
            myList.Add(node2);
            myList.Add(node3);
            myList.Add(node4);
            myList.Add(node5);
        }
    }
}
