﻿namespace DataBase.Program
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Guid AccountId { get; set; }
        public virtual Account Accounts {  get; set; }
    }
}
