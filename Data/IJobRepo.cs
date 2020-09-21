using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface IJobRepo
    {
        bool SaveChanges();

        IEnumerable<Job> GetAllJobs();
        Job GetJobById(int id);
        void AddJob(Job job);
    }
}
