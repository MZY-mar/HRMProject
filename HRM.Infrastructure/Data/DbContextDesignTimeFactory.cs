using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HRM.Infrastructure
{
    public class DbContextDesignTimeFactory : IDesignTimeDbContextFactory<HRMDbContext>
    {
        public HRMDbContext CreateDbContext(string[]args){
            DbContextOptionsBuilder< HRMDbContext> builder = new DbContextOptionsBuilder<HRMDbContext>();
            builder.UseSqlServer("Server=localhost;Database=dapper;User Id=sa;Password=root1234;Integrated Security=False;TrustServerCertificate=True");
            return new HRMDbContext(builder.Options);
        }
    }
}