using System;
using System.ComponentModel.DataAnnotations;

namespace AmeriForce.Data
{
    public class TestCompany
    {
        public TestCompany()
        {
            CreatedDate = DateTime.Now;
            LastModifiedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string SICCode { get; set; }
        public string CharterState { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        
        [Range(00001,99999)]
        [MinLength(5)]
        [MaxLength(5)]
        public int MailingPostalCode { get; set; }
    }
}
