using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class Facility
    {
        public Facility()
        {
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public string ClientID { get; set; }
        public string FacilityName { get; set; }
        public string FacilityType { get; set; }
        public string FacilityCategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
