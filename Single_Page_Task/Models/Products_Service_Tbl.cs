using System.ComponentModel.DataAnnotations;

namespace Single_Page_Task.Models
{
    public class Products_Service_Tbl
    {
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
    }
}
