using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriForce.Data
{
    public class LOV_TagGradeSort
    {
        public int ID { get; set; }
        public string Grade { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public LOV_TagGradeSort()
        {
            DateUpdated = DateTime.Now;
        }
    }
}
