using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class Submission
    {
        public int Id { get; set; }


        [Required]
        public int JobRequirementId { get; set; }

        [Required]
        public int CandidateId { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime ConfirmedOn { get; set; }
        public DateTime RejectedOn { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CurrentStatus { get; set; }
        public List<Status> Status { get; set; }
        public JobRequirement JobRequirement { get; set; }
        public Candidate Candidate { get; set; }
    }
}