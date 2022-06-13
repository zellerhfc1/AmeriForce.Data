using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class SICCode
    {
        public SICCode()
        {
            CreatedDate = DateTime.Now;
        }
        
        public string ID { get; set; }
        public string Value { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
