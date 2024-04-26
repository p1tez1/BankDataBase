namespace DataBase.Program
{
    public class Employes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Guid> CustomerIds {get; set;}
        public ICollection<Customer> Customers { get; set;} 
    }
}
