using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeriForce.Data
{
    public class Client
    {
        public Client()
        {
            CreatedDate = DateTime.Now;
            LastModifiedDate = DateTime.Now;
        }

        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StageName { get; set; }
        public int? StageSortOrder { get; set; }
        public int? Amount { get; set; }
        public int? ExpectedRevenue { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Type { get; set; }
        public string LeadSource { get; set; }
        public int? IsClosed { get; set; }
        public string ForecastCategory { get; set; }
        public string ForecastCategoryName { get; set; }
        public string OwnerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? SystemModstamp { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public DateTime? LastStageChangeDate { get; set; }
        public int? FiscalYear { get; set; }
        public int? FiscalQuarter { get; set; }
        public string ContactId { get; set; }
        public string LastAmountChangedHistoryId { get; set; }
        public string LastCloseDateChangedHistoryId { get; set; }
        public DateTime? Legal_Docs_Issued { get; set; }
        public DateTime? Legal_Docs_Received { get; set; }
        public DateTime? Legal_Docs_Time_Out { get; set; }
        public string External_Opportunity_ID { get; set; }
        public DateTime? AD_Credit_Review { get; set; }
        public int? Delayed_Opportunity { get; set; }
        public DateTime? All_Post_Funding_Tasks_Completed { get; set; }
        public string Approval_Decision { get; set; }
        public int? Approval_Decision_Time_1 { get; set; }
        public DateTime?    Bankruptcy_Search { get; set; }
        public DateTime?    BDO_Write_Up_Received { get; set; }
        public DateTime?    Client_Profile_Out { get; set; }
        public DateTime?    Client_Profile_In { get; set; }
        public DateTime?    Corporate_Verification { get; set; }
        public DateTime?    Criminal_Background_Search { get; set; }
        public DateTime?    D_B_Prospect { get; set; }
        public DateTime?    Due_Diligence_Deposit_Received { get; set; }
        public DateTime?    File_Received_by_UW { get; set; }
        public DateTime?    File_to_Client_Services { get; set; }
        public DateTime?    File_to_Mgmt_for_Review { get; set; }
        public DateTime?    First_Response { get; set; }
        public DateTime?    FTL_Search_State_County { get; set; }
        public DateTime?    Initial_Funding { get; set; }
        public DateTime?    Ins_Verification_Transp_Staff_only { get; set; }
        public DateTime?    Invoices_Rcd_Ready_to_Move_Fwd { get; set; }
        public DateTime?    Judgment_Search { get; set; }
        public DateTime?    Litigation_Search { get; set; }
        public string Lost_to_Competitor { get; set; }
        public DateTime? Mgmt_Completes_Post_Funding_File_Review { get; set; }
        public decimal Pre_Approval_Biz_Hours { get; set; }
        public string Reason_Lost { get; set; }
        public DateTime? Referral_Date { get; set; }
        public string Referring_Company { get; set; }
        public string Referring_Contact { get; set; }
        public DateTime? Searches_Requested { get; set; }
        public DateTime? Searches_Returned { get; set; }
        public DateTime? STL_Search { get; set; }
        public DateTime? Tax_Guard_Report { get; set; }
        public DateTime? Term_Sheet_Issued { get; set; }
        public DateTime? Term_Sheet_Received { get; set; }
        public DateTime? UCC_Search { get; set; }
        public DateTime? UW_Hands_over_for_First_Review { get; set; }
        public string NextActivityID { get; set; }

    }
}
