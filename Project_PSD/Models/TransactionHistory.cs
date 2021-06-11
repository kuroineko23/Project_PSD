using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Models
{
    public partial class TransactionHistory
    {
        public int THid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ShowName { get; set; }
        public DateTime ShowTime { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
