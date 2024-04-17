namespace DataBase.Program
{
    public class Employes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customers { get; set; }
        public ICollection<Customer> Customer {get; set;}
    }
}
