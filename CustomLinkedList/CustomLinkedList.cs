using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class CustomLinkedList<T>
    {
        T[] customLinkedList;
        private LinkedListNode<T> headNode;
        private LinkedListNode<T> currentNode;
        private LinkedListNode<T> firstNode;
        private LinkedListNode<T> lastNode;

        public CustomLinkedList()
        {
            customLinkedList = new T[0];
        }

        public CustomLinkedList(T[] argumentValue)
        {
            this.customLinkedList = argumentValue;
        }

        public void AddFirstNode(T argumentValue)
        {
            //add item to the head of linked list
            firstNode = new LinkedListNode<T>();
            firstNode.data = argumentValue;
            firstNode.next = headNode;
            headNode = firstNode;
        }

        public void AddLastNode(T argumentValue)
        {
            //add item to the tail of linked list
            if (headNode == null)
            {
                headNode = new LinkedListNode<T>();
                headNode.data = argumentValue;
                headNode.next = null;
            }
            else
            {
                lastNode = new LinkedListNode<T>();
                lastNode.data = argumentValue;
                currentNode = headNode;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = lastNode;
            }
        }
        public void PrintLinkedList()
        {
            currentNode = headNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }
    }
}
