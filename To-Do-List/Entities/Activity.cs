using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Entities
{
    internal class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ActivitySite { get; set; }
        public int NumberOfPeopleAllowed { get; set; }
        public int DisabilityTypeId { get; set; }
        public DisabilityType DisabilityType { get; set; }
        public ICollection<ActivityStudent> ActivityStudents { get; set; }
    }
}
