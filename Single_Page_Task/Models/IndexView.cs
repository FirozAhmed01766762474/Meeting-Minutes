namespace Single_Page_Task.Models
{
    public class IndexView
    {


        public  List<Products_Service_Tbl>? productserviceName { get; set; }

        public  List<Corporate_Customer_Tbl>? CorporateCustomer { get; set;}

        public List<Individual_Customer_Tbl>? IndividualCustomer { get; set;}

        public List<MeetingMinutesDetails>? MeetingMinutesDetails { get; set;}
        public Meeting_Minutes_Master? MeetingMinutesMaster { get; set;}
    }
}
