using System;

namespace Question_1b
{
    public class Customer
    {
        private string name;

        // Constructor for the Customer class that takes the customer name as a parameter
        public Customer(string name)
        {
            // Assign the provided name to the private 'name' field of the Customer object
            this.name = name;
        }

        // Property to get or set the name of the customer
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method to get the information of the customer as a formatted string
        public string GetInformation()
        {
            return $"Name: {this.name}";
        }
    }
}