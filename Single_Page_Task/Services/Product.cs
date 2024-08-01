using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Single_Page_Task.Data;
using Single_Page_Task.Models;
using System.Data;
using System.Diagnostics.Metrics;

namespace Single_Page_Task.Services
{
    public class Product : IProduct
    {
        private readonly DataContext _context;
        private readonly string _connectionString;

        public Product(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("apicon");
        }
        public IndexView index()
        {
            var _productserviceName = _context.Products_Service_Tbl.ToList();
            var _corporatecustomerName = _context.Corporate_Customer_Tbl.ToList();
            var _IndividualcustomarName = _context.Individual_Customer_Tbl.ToList();
            var data = new IndexView()
            {
                productserviceName = _productserviceName,
                CorporateCustomer = _corporatecustomerName,
                IndividualCustomer = _IndividualcustomarName

            };

            return data;
        }

       public void savetodetailstable(List<MeetingMinutesDetails> details)
        {
            if(details.Count > 0)
            {
                foreach(var item  in details)
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        using (var command = new SqlCommand("Meeting_Minutes_Details_Save_SP", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@Service", item.Service);
                            command.Parameters.AddWithValue("@Quantity", item.Quantity);
                            command.Parameters.AddWithValue("@Unit", item.Unit);
                            connection.Open();
                            command.ExecuteNonQuery(); // This line executes the stored procedure
                        }
                    }

                }
            }
            
        }

        public void savetomastartable(Meeting_Minutes_Master master)
        {
            string dateOnly = master.DateTime.Date.ToString("yyyy-MM-dd");
            Meeting_Minutes_Master_Tbl Master = new Meeting_Minutes_Master_Tbl()
            {
                CustomerName = master.CustomerName,
                DateTime = dateOnly +" "+ master.Time.ToString(),
                MeetingPlace = master.MeetingPlace,
                AttendsFromClientSide = master.AttendsFromClientSide,
                AttendsFromHomeSide = master.AttendsFromHomeSide,
                MeetingAgenda = master.MeetingAgenda,
                MeetingDiscussion = master.MeetingDiscussion,
                MeetingDiscision = master.MeetingDiscision

            };
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("[dbo].[Meeting_Minutes_Master_Save_SP]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerName", Master.CustomerName);
                    command.Parameters.AddWithValue("@DateTime", Master.DateTime);
                    command.Parameters.AddWithValue("@MeetingPlace", Master.MeetingPlace);
                    command.Parameters.AddWithValue("@AttendsFromClientSide", Master.AttendsFromClientSide);
                    command.Parameters.AddWithValue("@AttendsFromHomeSide", Master.AttendsFromHomeSide);
                    command.Parameters.AddWithValue("@MeetingAgenda", Master.MeetingAgenda);
                    command.Parameters.AddWithValue("@MeetingDiscussion", Master.MeetingDiscussion);
                    command.Parameters.AddWithValue("@MeetingDiscision", Master.MeetingDiscision);

                    connection.Open();
                    command.ExecuteNonQuery(); // This line executes the stored procedure
                }
            }

            // No need to call _context.SaveChanges() since this operation is not using Entity Framework


        }
    }
}
