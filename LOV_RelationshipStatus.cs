using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriForce.Data
{
    public class LOV_RelationshipStatus
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public LOV_RelationshipStatus()
        {
            DateUpdated = DateTime.Now;
        }
    }
}

