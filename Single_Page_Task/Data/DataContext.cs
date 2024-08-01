using Microsoft.EntityFrameworkCore;
using Single_Page_Task.Models;

namespace Single_Page_Task.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder
        //        .UseSqlServer("Server=DESKTOP-21UHJJD\\SQLEXPRESS;Database=MeetingMinitues;Trusted_Connection=true;");

        //}

        public DbSet<Products_Service_Tbl> Products_Service_Tbl { get; set; }
        public DbSet<Corporate_Customer_Tbl> Corporate_Customer_Tbl { get; set; }
        public DbSet<Individual_Customer_Tbl> Individual_Customer_Tbl { get; set; }
        public DbSet<Meeting_Minutes_Master_Tbl> Meeting_Minutes_Master_Tbl { get; set; }
        public DbSet<Meeting_Minutes_Details_Tbl> Meeting_Minutes_Details_Tbl { get; set; }




    }
}
