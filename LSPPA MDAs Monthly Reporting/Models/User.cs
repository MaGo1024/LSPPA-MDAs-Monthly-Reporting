namespace LSPPA_MDAs_Monthly_Reporting.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }

        public string? ProcurementOfficer { get; set; }

        public string? AccountingOfficer { get; set; }

        public int MdaId { get; set; }

    }
}
