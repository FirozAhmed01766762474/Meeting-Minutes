using System.ComponentModel.DataAnnotations;

namespace Single_Page_Task.Models
{
    public class Meeting_Minutes_Details_Tbl
    {
        [Key]
        public int Id { get; set; }

        public string Service { get; set; }

        public int Quantity { get; set; }

        public int Unit { get; set; }
    }
}
