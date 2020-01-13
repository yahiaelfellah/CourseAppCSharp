using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProjectApp.Models
{
    public class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid OrganizationId { get; set; }

        [StringLength(50)]
        [Required]
        public string BusinessName { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Profession { get; set; }

        [ForeignKey("AspNetUserId")]
        public ApplicationUser User { get; set; }
      
        public string AspNetUserId { get; set; }
    }
}
