using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FarmAndTrace.Model
{
    public class Client
    {
        [Key]
        public long ClientId { get; set; }
        public long Name { get; set; }
        public long Street { get; set; }
        public long ZIP { get; set; }
        public long Country { get; set; }


        public ICollection<Transaction> Transactions { get; set; }
    }
}
