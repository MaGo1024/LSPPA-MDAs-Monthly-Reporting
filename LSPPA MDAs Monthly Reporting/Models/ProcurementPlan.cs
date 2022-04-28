namespace LSPPA_MDAs_Monthly_Reporting.Models
{
    public class ProcurementPlan
    {
        public int Id { get; set; }
        public int AnnualApprovedProcPlanNumber { get; set; }
        public int AnnualApprovedProcPlanValue { get; set; }
        public int MonthlyApprovedProcPlanNumber { get; set; }
        public int MonthlyApprovedProcPlanValue { get; set; }

        // Year To Date number = summation of all current Monthly number 
        public int YTDApprovedProcPlanValue { get; set; }

        // Year To Date number = summation of all current Monthly number 
        public int YTDApprovedProcPlanNumber { get; set; }

        public int PpaApproval { get; set; }
        public int ValuationOfficeTotalestimate { get; set; }
        public int TotalAmountRealisedAfterProcess { get; set; }

        // Value for Money = ValuationOfficeTotalestimate - TotalAmountRealisedAfterProcess
        public int ValueForMoney { get; set; }



    }
}

