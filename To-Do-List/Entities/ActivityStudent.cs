using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class ActivityStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public DateTime RegistrationDate { get; set; }
        public bool IsAccept { get; set; }
        public string Notes { get; set; }
    }
}
