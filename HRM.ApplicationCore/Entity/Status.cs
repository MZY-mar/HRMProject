using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Entity
{
    public class Status
    {
         public int Id { get; set; }

         [Required]
        [Column(TypeName = "varchar(30)")]
        public string State { get; set; }

        [Required]
        public DateTime? ChangedOn { get; set; }

        [Required]
        [Column(TypeName = "varchar(70)")]
        public string StatusMessage { get; set; }
         
        [Required]
        public int SubmissionId { get; set; }
        //naviagational property
        public Submission Submission { get; set; }
    }
}