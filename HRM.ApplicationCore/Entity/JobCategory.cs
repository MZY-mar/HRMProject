using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class JobCategory
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Name { get; set; }
        public List<JobRequirement> JobRequirements { get; set; }
    }
}