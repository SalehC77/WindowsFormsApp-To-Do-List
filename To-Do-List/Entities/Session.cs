using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Session
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public DateTime SessionDate { get; set; }
        public DateTime DurationMinutes { get; set; }
        public decimal Price { get; set; }
        public string Notes { get; set; }

    }
}
