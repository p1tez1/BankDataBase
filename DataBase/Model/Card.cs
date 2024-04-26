using System.Data;

namespace DataBase.Program
{
    public class Card
    {
        public Guid Id { get; set; }
        public int Owner { get; set; }
        public int Card_Number { get; set; }
        public int CVV { get; set; }
        public DateTime Valid_Thru { get; set; }
        public int Balance { get; set; }
        public ICollection<Guid> TransactionIds { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
