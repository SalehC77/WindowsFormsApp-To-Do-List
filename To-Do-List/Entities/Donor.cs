using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Donor
    {
        public int Id { get; set; }
        
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public ICollection<Donation> Donations { get; set; }
    }
}
