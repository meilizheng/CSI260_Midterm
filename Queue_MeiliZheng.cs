using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI260_Midterm
{
    public class Queue_MeiliZheng
    {
        public class Queue<T>
        {
            private T[] elements;
            private int front; // Index of the front element
            private int rear; // Index of the rear element
            private int count; // Number of elements in the queue
            private const int defaultCapacity = 10;

            // Constructor
            public Queue()
            {
                elements = new T[defaultCapacity];
                front = 0;
                rear = -1;
                count = 0;
            }

            // Enqueue method to add an element to the rear of the queue
            public void Enqueue(T item)
            {
                // Check if the queue is full
                if (count == elements.Length)
                {
                    // If full, resize the array to double its current size
                    Array.Resize(ref elements, elements.Length * 2);
                }
                // Increment rear and insert the new item
                rear = (rear + 1) % elements.Length;
                elements[rear] = item;
                count++;
            }

            // Dequeue method to remove and return the front element from the queue
            public T Dequeue()
            {
                // Check if the queue is empty
                if (count == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }
                // Retrieve the front element and increment front
                T dequeuedItem = elements[front];
                elements[front] = default(T); // Clear the reference to help with garbage collection
                front = (front + 1) % elements.Length;
                count--;
                return dequeuedItem;
            }

            // Peek method to return the front element without removing it
            public T Peek()
            {
                // Check if the queue is empty
                if (count == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }
                return elements[front];
            }

            // Property to get the number of elements in the queue
            public int Count
            {
                get { return count; }
            }

            // Method to check if the queue is empty
            public bool IsEmpty()
            {
                return count == 0;
            }

            // Method to clear the queue
            public void Clear()
            {
                Array.Clear(elements, 0, elements.Length);
                front = 0;
                rear = -1;
                count = 0;
            }
        }
    }
}
