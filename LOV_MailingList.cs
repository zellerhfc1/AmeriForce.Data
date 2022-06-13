using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriForce.Data
{
    public class LOV_MailingList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public LOV_MailingList()
        {
            UpdateDate = DateTime.Now;
        }
    }
}
