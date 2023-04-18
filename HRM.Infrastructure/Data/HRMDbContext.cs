using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Data
{
    public class HRMDbContext :DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options):base(options)
        {

        }
        public DbSet<Candidate> Candidate { get; set; }
    }
}