using System.ComponentModel.DataAnnotations;

namespace Single_Page_Task.Models
{
    public class Corporate_Customer_Tbl
    {
        [Key]
        public int Id { get; set; }
        public string? CorporateCustomerName { get; set; }
    }
}
