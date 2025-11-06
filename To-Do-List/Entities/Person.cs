using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public ICollection<Student> Students { get; set; }
        //public ICollection<Donor> Donors { get; set; }
        //public ICollection<Staff> Staffs { get; set; }
    }
}
