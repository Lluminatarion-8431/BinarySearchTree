using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    public class BinarySearchTree
    {
        public Node head;

        public void Add(int item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data == newNode.Data) break;
                else if (currentNode.Data > newNode.Data)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        break;
                    }
                    currentNode = currentNode.left;
                }
                else if (currentNode.Data < newNode.Data)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        break;
                    }
                    currentNode = currentNode.right;
                }
            }
        }
    }
}
