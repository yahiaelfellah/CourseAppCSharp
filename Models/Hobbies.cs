using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CourseProjectApp.Models
{
    public class Hobbies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public Guid HobbieId { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public int Rating { get; set; }

        [ForeignKey("AspNetUserId")]
        public ApplicationUser User { get; set; }
        public string AspNetUserId { get; set; }
    }
}
