using System;

namespace Question_1b
{
    public class Queue
    {
        // Declare variables to manage the queue
        private int head = 0;               // Index of the head element
        private int tail = 0;               // Index of the tail element
        private Customer[] buffer;          // Array to store the customers
        private int numItems = 0;           // Number of items in the queue
        private readonly int MAXIMUM = 20;  // Maximum capacity of the queue

        // Constructor that initializes the queue with a maximum size of 20
        public Queue()
        {
            this.buffer = new Customer[this.MAXIMUM];
        }

        // Constructor that initializes the queue with a custom size
        public Queue(int size)
        {
            this.buffer = new Customer[size];
        }

        // Add a customer to the queue
        public void Enqueue(Customer customer)
        {
            // Check if the queue is already at maximum capacity
            if (numItems == MAXIMUM)
            {
                Console.WriteLine("The Queue is currently at the maximum");
                return;
            }

            // Add the customer to the tail of the queue
            buffer[tail] = customer;
            tail += 1;
            numItems += 1;
        }

        // Remove and return the customer at the head of the queue
        public Customer Dequeue()
        {
            // Check if the queue is currently empty
            if (numItems == 0)
            {
                Console.WriteLine("The Queue is currently empty, you can't delete from an empty queue");
                return null;
            }

            // Get the customer at the head of the queue
            Customer headItem = buffer[head];

            // Update the queue by moving the head to the next position
            numItems -= 1;
            head += 1;

            return headItem;
        }

        // Check if the queue is full
        public bool IsFull()
        {
            if (numItems == MAXIMUM)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Get the array of customers in the queue
        public Customer[] getCustomers()
        {
            return buffer;
        }

        // Get the number of items in the queue
        public int itemsNumber
        {
            get { return numItems; }
        }

        // Get the index of the head element in the queue
        public int Head
        {
            get { return head; }
        }

        // Get the index of the tail element in the queue
        public int Tail
        {
            get { return tail; }
        }

        // Check if the queue is empty
        public bool IsEmpty()
        {
            if (numItems == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
