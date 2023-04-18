using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Entity
{
    public class EmployeeRequirementType
    {
        public int Id { get; set; }
         [Required]
        public int JobRequirementId { get; set; }
         [Required]
        public int EmployeeTypeId { get; set; }

        public JobRequirement JobRequirement { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}