using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class LOV_ReferralType
    {
        public LOV_ReferralType()
        {
            DateCreated = DateTime.Now;
        }
        

        public int ID { get; set; }
        public string ReferralType { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
