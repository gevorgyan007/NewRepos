using CunsomerServiceLibrary;

namespace MocktEST
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        
        //public StatusLevel StatusLevel { get; set; }
       // public int ID { get; set; }
        
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer()
        {
        }
    }

    public enum StatusLevel
    {
        Gold,Silver,Bronze
    }
}
