using static CSI260_Midterm.LinkList_Double_MeiliZheng;
using static CSI260_Midterm.LinkList_Single_MeiliZheng;

namespace CSI260_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList();
            LinkedListDouble();
            Stack();
            Queue();
        }

        public static void SingleLinkList()
        {
            SinglyLinkedList<string> myList = new SinglyLinkedList<string>();

            // Add elements to the linked list
            myList.Add("first");
            myList.Add("second");
            myList.Add("third");

            // Remove an element
            myList.Remove("second");

            // Test the Display method to print the elements
            Console.WriteLine("Linked List Elements:");
            myList.Print();

            int index = 1;
            Console.WriteLine($"The element at index {index} is {myList[index]}\n");
        }

        public static void LinkedListDouble()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();

            // Add elements
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            // Display forward and backward
            Console.WriteLine("Forward:");
            linkedList.DisplayForward();
            Console.WriteLine("Backward:");
            linkedList.DisplayBackward();

            // Remove an element
            if (linkedList.Remove(20))
                Console.WriteLine("20 removed");

            // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            // Insert elements at specific positions
            linkedList.InsertAtIndex(1, 25); // Insert 25 at index 1
            linkedList.InsertAtFront(5);     // Insert 5 at the beginning
            linkedList.InsertAtEnd(35);      // Insert 35 at the end

            // Display forward after insertion
            Console.WriteLine("Forward (after insertion):");
            linkedList.DisplayForward();

            // Remove elements at specific positions
            linkedList.RemoveAtFront(); // Remove the first element
            linkedList.RemoveAtEnd();   // Remove the last element
            linkedList.RemoveAtIndex(2); // Remove the element at index 2

            // Display forward after removal
            Console.WriteLine("Forward (after removal):");
            linkedList.DisplayForward();

            // Clear the linked list
            linkedList.Clear();

            // Display forward after clearing
            Console.WriteLine("Forward (after clearing):");
            linkedList.DisplayForward();

            Console.ReadLine();
        }

        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();

            // Push elements
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Pop an element
            Console.WriteLine($"Popped: {stack.Pop()}");

            // Peek at the top element
            Console.WriteLine($"Top element: {stack.Peek()}");

            // Display count
            Console.WriteLine($"Count: {stack.Count}\n");

            Console.ReadLine();
        }

        public static void Queue()
        {

            Queue<int> queue = new Queue<int>();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Dequeue an element
            Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            // Peek at the front element
            Console.WriteLine($"Front element: {queue.Peek()}");

            // Display count
            Console.WriteLine($"Count: {queue.Count}\n");

            Console.ReadLine();
        }
    }
}