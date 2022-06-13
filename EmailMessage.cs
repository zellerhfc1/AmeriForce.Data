using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class EmailMessage
    {
public string Id { get; set; }
public string ActivityId { get; set; }
        public string CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? SystemModstamp { get; set; }
        public string TextBody { get; set; }
        public string HtmlBody { get; set; }
        public string Subject { get; set; }
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string CcAddress { get; set; }
        public string BccAddress { get; set; }
        public int? HasAttachment { get; set; }
        public int? Status { get; set; }
        public DateTime? MessageDate { get; set; }
        public int? MessageSize { get; set; }
        public string MessageIdentifier { get; set; }
        public string ThreadIdentifier { get; set; }
        public int? IsTracked { get; set; }
        public DateTime? FirstOpenedDate { get; set; }
        public DateTime? LastOpenedDate { get; set; }
        public string RelatedTo { get; set; }
        public string TemporaryID { get; set; }

    }
}
