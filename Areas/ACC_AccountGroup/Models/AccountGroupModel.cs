namespace Hackathone.Areas.ACC_AccountGroup.Models
{
    public class AccountGroupModel
    {
        public int? AccountGroupID { get; set; }
        public string? AccountGroupName { get; set; }
        public string? AccountGroupPrintName { get; set; }
        public string? BalanceSheetName { get; set; }
        public string? ParentAccountGroupID_AccountGroupName { get; set; }
        public string? ParentAccountGroupID_BalanceSheetName { get; set; }
        public string? TopAccountGroupID_AccountGroupName { get; set; }

        public string? TopAccountGroupID_BalanceSheetName { get; set; }
        public string? RelativeAccountGroupID_BalanceSheetName { get; set; }

        public string? RelativeAccountGroupID_AccountGroupName { get; set; }
        public string? ReportType { get; set; }

        public string? AccountIn { get; set; }
        public string? BalanceOn { get; set; }
        public string? IsEditable { get; set; }

        public string? FlowType { get; set; }

        public string? Remarks { get; set; }

        public string? CompanyName { get; set; }

        public string? UserName { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
