using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class SqlJobRepo : IJobRepo
    {
        private readonly JobContext _context;

        public SqlJobRepo(JobContext context)
        {
            _context = context;
        }

        public void AddJob(Job job)
        {
            if(job == null)
            {
                throw new ArgumentNullException(nameof(job));
            }
            _context.Jobs.Add(job);
        }

        public IEnumerable<Job> GetAllJobs()
        {
            return _context.Jobs.ToList();
        }

        public Job GetJobById(int id)
        {
            return _context.Jobs.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
