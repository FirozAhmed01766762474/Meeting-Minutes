using System.ComponentModel.DataAnnotations;

namespace Single_Page_Task.Models
{
    public class Meeting_Minutes_Master_Tbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public string DateTime { get; set; }

        
        [Required]
        public string MeetingPlace { get; set; }
        [Required]
        public string AttendsFromClientSide { get; set; }

        [Required]
        public string AttendsFromHomeSide { get; set; }
        [Required]
        public string MeetingAgenda { get; set; }

        [Required]
        public string MeetingDiscussion {get; set;}

        [Required]
        public string MeetingDiscision { get; set; }


    }
}
