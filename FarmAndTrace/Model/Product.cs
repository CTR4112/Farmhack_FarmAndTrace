using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FarmAndTrace.Model
{
    public class Product
    {
        [Key]
        public long ProductId { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; private set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
