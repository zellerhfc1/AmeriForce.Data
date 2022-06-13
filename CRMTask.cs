using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class CRMTask
    {

        public CRMTask()
        {
            CreatedDate = DateTime.Now;
            LastModifiedDate = DateTime.Now;
        }


        public string Id { get; set; }
        public string WhoId { get; set; }
        public string WhatId { get; set; }
        public int? WhoCount { get; set; }
        public int? WhatCount { get; set; }
        public string Subject { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string OwnerId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string CompanyId { get; set; }
        public int? IsClosed { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? SystemModstamp { get; set; }
        public int? IsArchived { get; set; }
        public string EmailMessageId { get; set; }
        public int? ActivityOriginType { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public int? IsReminderSet { get; set; }
        public string RecurrenceActivityId { get; set; }
        public int? IsRecurrence { get; set; }
        public DateTime? RecurrenceStartDateOnly { get; set; }
        public DateTime? RecurrenceEndDateOnly { get; set; }
        public string RecurrenceTimeZoneSidKey { get; set; }
        public string RecurrenceType { get; set; }
        public int? RecurrenceInterval { get; set; }
        public int? RecurrenceDayOfWeekMask { get; set; }
        public int? RecurrenceDayOfMonth { get; set; }
        public string RecurrenceInstance { get; set; }
        public string RecurrenceMonthOfYear { get; set; }

        public DateTime? CompletedDateTime { get; set; }



    }
}
