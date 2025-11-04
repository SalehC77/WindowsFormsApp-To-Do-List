using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string EducationalStage { get; set; }
        public int DisabilityTypeId { get; set; }
        public DisabilityType DisabilityType { get; set; }
        
        public ICollection<ActivityStudent> ActivityStudents { get; set; }
    }
}
