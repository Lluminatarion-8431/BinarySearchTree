using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    public class BinarySearchTree
    {
        public Node rootNode;

        public void Add(int item)
        {
            Node newNode = new Node(item);
            if (rootNode == null)
            {
                rootNode = newNode;
                return;
            }
            Node currentNode = rootNode;
            while (currentNode != null)
            {
                if (currentNode.Data == newNode.Data) break;
                else if (currentNode.Data > newNode.Data)
                {
                    if (currentNode.leftNode == null)
                    {
                        currentNode.leftNode = newNode;
                        break;
                    }
                    currentNode = currentNode.leftNode;
                }
                else if (currentNode.Data < newNode.Data)
                {
                    if (currentNode.rightNode == null)
                    {
                        currentNode.rightNode = newNode;
                        break;
                    }
                    currentNode = currentNode.rightNode;
                }
            }
        }
        public bool Search(int value)
        {
            bool found = false;
            string directions = "";
            Node currentNode = rootNode;
            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    found = true;
                    break;
                }
                else if (currentNode.Data > value)
                {
                    directions += currentNode.Data + " Left\n";
                    currentNode = currentNode.leftNode;
                }
                else if (currentNode.Data < value)
                {
                    directions += currentNode.Data + " Right\n";
                    currentNode = currentNode.rightNode;
                }
            }
            if (found)
            {
                Console.WriteLine("Found " + value + "!!!\n" + directions);
            }
            else
            {
                Console.WriteLine("Not found.\n" + directions);
            }
            return found;
        }
    }
}
