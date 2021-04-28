using System;
using System.Collections.Generic;
using System.Text;
using EmreYildirimStudentFormHW.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmreYildirimStudentFormHW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Student> Students { get; set; }
    }
}