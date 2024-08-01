using Single_Page_Task.Models;

namespace Single_Page_Task.Services
{
    public interface IProduct
    {

        public IndexView index();

        public void savetomastartable(Meeting_Minutes_Master master);
        public void savetodetailstable(List<MeetingMinutesDetails> details);
    }
}
