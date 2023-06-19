namespace Question_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Queue class to manage customers
            Queue myQueue = new Queue();

            // Start an infinite loop to continuously process user commands
            while (true)
            {
                // Prompt the user to enter a command
                Console.WriteLine("Enter a command: add or remove or count or list");
                string command = Console.ReadLine();

                // Check the user's command and perform the corresponding action
                if (command == "add")
                {
                    // Prompt the user to enter the name of the customer to be added
                    Console.Write("Enter the name of the customer: ");
                    string customerName = Console.ReadLine();

                    // Check if the user entered a valid customer name
                    if (customerName == null)
                    {
                        Console.Write("You must enter a customer name");
                        break; // Exit the loop if a valid customer name is not provided
                    }

                    // Create a new Customer object with the entered name
                    Customer customer = new Customer(customerName);

                    // Add the customer to the queue
                    myQueue.Enqueue(customer);

                    // Print a message confirming the addition of the customer to the queue
                    Console.WriteLine("Added '{0}' to the queue.", customerName);
                }

                else if (command == "remove")
                {
                    // Check if the queue is currently empty
                    if (myQueue.IsEmpty())
                    {
                        Console.WriteLine("The Queue is currently empty");
                    }
                    else
                    {
                        // Remove the customer from the queue and get the removed customer
                        Customer customer = myQueue.Dequeue();

                        // Print the name of the removed customer
                        Console.WriteLine($"Customer named: {customer.Name}, was deleted");
                    }
                }
                else if (command == "count")
                {
                    // Print the current size of the queue
                    Console.WriteLine("The queue size is: {0}", myQueue.itemsNumber);
                }
                else if (command == "list")
                {
                    // Initialize a counter variable to keep track of the customer number
                    int counter = 1;

                    // Iterate through the customers in the queue and print their names
                    for (int i = myQueue.Head; i != myQueue.Tail; i++)
                    {
                        // Get the customer at the current index
                        Customer customer = myQueue.getCustomers()[i];

                        // Print the customer number and name
                        Console.WriteLine($"{counter}: {customer.Name}");

                        // Increment the counter
                        counter++;
                    }

                    // Print an empty line for readability
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Oops! something went wrong. Please try again.");
                }
            }
        }
    }
}