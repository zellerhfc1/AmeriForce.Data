using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class ClientContactRole
    {
        public string Id { get; set; }
        public string ClientID { get; set; }
        public string ContactId { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime SystemModstamp { get; set; }

    }
}
