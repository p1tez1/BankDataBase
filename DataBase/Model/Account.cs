using System;

namespace DataBase.Program
{
    public class Account
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string last_Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public int Balanc { get; set; }
        public List<Card> Card { get; set; }
        
    }
}
