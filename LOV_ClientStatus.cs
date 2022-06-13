using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{

    public class LOV_ClientStatus
    {
        public LOV_ClientStatus()
        {
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public string ClientStatus { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
