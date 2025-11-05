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
        
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string EducationalStage { get; set; }
        public bool IsAccept { get; set; }
        public int DisabilityTypeId { get; set; }
        public DisabilityType DisabilityType { get; set; }
        
        public ICollection<ActivityStudent> ActivityStudents { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
