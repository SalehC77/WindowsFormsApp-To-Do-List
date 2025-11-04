using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public Donor Donor { get; set; } 
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime DonationDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Purpose { get; set; }
    }
}
