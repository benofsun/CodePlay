using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcSampleWebApp.Models
{
    public class PrintJob
    {
        public int ID { get; set; }
        public int AffiliateID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerCity { get; set; }
        [Required]
        public string CustomerState { get; set; }
        [Required]
        public string CustomerZip { get; set; }
        [Required]
        public DateTime JobSubmitDate { get; set; }
        [Required]
        public DateTime JobEstCompleteDate { get; set; }
    }

    public class PrintJobDBContext : DbContext
    {
        public DbSet<PrintJob> PrintJobs { get; set; }
    }
}


