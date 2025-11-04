using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Staff
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int StaffTypeId { get; set; }
        public StaffType StaffType { get; set; }
        public decimal Salary { get; set; }
        public string Education { get; set; }
        public DateTime HireDate { get; set; }
        public string Experience { get; set; }

        public string NationalId { get; set; }

        public string PassportNumber { get; set; }
       

       

    }
}
