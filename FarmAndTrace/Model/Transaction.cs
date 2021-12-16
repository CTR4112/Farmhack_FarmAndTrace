using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmAndTrace.Model
{
    public class Transaction
    {
        [Key]
        public long TransactionId { get; set; }
        public string RFID { get; private set; }
        public misc.Action Action { get; private set; }
        public DateTime Timestamp { get; private set; }
        public float Longitude { get; private set; }
        public float Latitude { get; private set; }
        public float Unit { get; private set; }

        public long ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public long ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
