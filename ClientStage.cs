using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class ClientStage
    {
        public ClientStage()
        {
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayValue { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
