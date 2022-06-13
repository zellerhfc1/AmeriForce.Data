using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriForce.Data
{
    public class LOV_CompanyType
    {
        public LOV_CompanyType()
        {
            DateCreated = DateTime.Now;
        }

        public int ID { get; set; }
        public string ReferralType { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
