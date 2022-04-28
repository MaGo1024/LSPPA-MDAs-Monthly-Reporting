using System.ComponentModel.DataAnnotations;

namespace LSPPA_MDAs_Monthly_Reporting.Models
{
    public class MDA
    {
        public int MdaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? MdaName { get; set; }

        public string? MonthofReport { get; set; }
    }
}
