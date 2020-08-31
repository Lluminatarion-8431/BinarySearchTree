using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    class BinarySearchTree
    {
        public Node RootNode;
        //public Node LastNode;

        public void Add(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
                //LastNode = RootNode;
            }
            else
            {
                //LastNode.NextNode = nodeToAdd;
                //LastNode = LastNode.NextNode;

                Node currentNode = RootNode;
                while (true)
                {
                    if (currentNode.NextNode == null)
                    {
                        currentNode.NextNode = nodeToAdd;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.NextNode;
                    }
                }


            }

        }
    }
}
