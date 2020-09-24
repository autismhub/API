using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    // This is needed for communicating with the database
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> opt) : base(opt)
        {
            
        }

        private DbSet<Job> _jobs;

        public DbSet<Job> Jobs
        {
            get { return _jobs; }
            set { _jobs = value; }
        }

    }
}
