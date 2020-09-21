using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> opt) : base(opt)
        {
            
        }

        #region Fields
        private DbSet<Job> _jobs;
        private DbSet<User> _users;
        #endregion

        #region Properties
        public DbSet<Job> Jobs
        {
            get { return _jobs; }
            set { _jobs = value; }
        }

        public DbSet<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }
        #endregion










    }
}
