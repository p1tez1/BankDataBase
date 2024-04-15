using System.Data;

namespace DataBase.Program
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime Execution_Date { get; set; }
        public bool IsCompleted { get; set; }

    }
}
