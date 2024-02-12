using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI260_Midterm
{
    public class LinkList_Single_MeiliZheng
    {
        public class SinglyLinkedList<T>
        {
            // Node class representing each element in the linked list
            private class Node
            {
                public T Data { get; set; }
                public Node Next { get; set; }

                public Node(T data)
                {
                    Data = data;
                    Next = null;
                }
            }
            private Node head; // The first node in the list
            private int count; // Number of elements in the list
                               // Constructor
            public SinglyLinkedList()
            {
                head = null;
                count = 0;
            }

            // Method to add an element to the end of the list
            public void Add(T data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
                count++;
            }

            // Method to remove the first occurrence of a specific element from the list
            public bool Remove(T data)
            {
                if (head == null)
                {
                    return false;
                }

                if (head.Data.Equals(data))
                {
                    head = head.Next;
                    count--;
                    return true;
                }

                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        count--;
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            // Method to get the count of elements in the list
            public int Count
            {
                get { return count; }
            }

            // Method to clear the list
            public void Clear()
            {
                head = null;
                count = 0;
            }

            // Method to check if the list contains a specific element
            public bool Contains(T data)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            // Method to print the elements of the list
            public void Print()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            public T this[int index]
            {
                get
                {
                    if (index < 0 || index >= count)
                    {
                        throw new IndexOutOfRangeException("Index is out of range");
                    }

                    Node current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    return current.Data;
                }
            }
        }
    }
}
