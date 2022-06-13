using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class Company
    {
        public Company()
        {
            //CreatedDate = DateTime.Now;
            LastModifiedDate = DateTime.Now;
        }


        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public String CompanyType { get; set; }

        public string SICCode { get; set; }
        public string CharterState { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingPostalCode { get; set; }

    }
}
