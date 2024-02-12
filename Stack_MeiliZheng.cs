using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI260_Midterm
{
    public class Stack_MeiliZheng
    {
        public class Stack<T>
        {
            private T[] elements;
            private int top; // Index of the top element
            private const int defaultCapacity = 10;

            // Constructor
            public Stack()
            {
                elements = new T[defaultCapacity];
                top = -1; // Stack is initially empty
            }

            // Push method to add an element to the stack
            public void Push(T item)
            {
                // Check if the stack is full
                if (top == elements.Length - 1)
                {
                    // If full, resize the array to double its current size
                    Array.Resize(ref elements, elements.Length * 2);
                }
                // Increment top and insert the new item
                elements[++top] = item;
            }

            // Pop method to remove and return the top element from the stack
            public T Pop()
            {
                // Check if the stack is empty
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                // Retrieve the top element and decrement top
                T poppedItem = elements[top];
                elements[top--] = default(T); // Clear the reference to help with garbage collection
                return poppedItem;
            }

            // Peek method to return the top element without removing it
            public T Peek()
            {
                // Check if the stack is empty
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return elements[top];
            }

            // Property to get the number of elements in the stack
            public int Count
            {
                get { return top + 1; }
            }

            // Method to check if the stack is empty
            public bool IsEmpty()
            {
                return top == -1;
            }

            // Method to clear the stack
            public void Clear()
            {
                Array.Clear(elements, 0, elements.Length);
                top = -1;
            }
        }
    }
}
