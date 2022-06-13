using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class LOV_TemplateType
    {
        public int ID { get; set; }
        public string TemplateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
