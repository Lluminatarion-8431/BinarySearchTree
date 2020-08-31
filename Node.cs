﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    public class Node
    {
        public int data;
        public Node right;
        public Node left;

        public Node(int value)
        {
            data = value;
        }

        public int Data
        {
            get { return data; }

            set { data = value; }

        }
    }
}
