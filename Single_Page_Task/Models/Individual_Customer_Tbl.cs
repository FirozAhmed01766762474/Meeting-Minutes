using System.ComponentModel.DataAnnotations;

namespace Single_Page_Task.Models
{
    public class Individual_Customer_Tbl
    {
        [Key]
        public int Id { get; set; }
        public string? Individual_CustomerName { get; set; }
    }
}
