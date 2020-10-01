using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    // This is the methods implemented in the repositories
    public interface IJobRepo
    {
        bool SaveChanges();

        IEnumerable<Job> GetAllJobs();
        Job GetJobById(int id);
        void CreateJob(Job job);
        void UpdateJob(Job job);
        void DeleteJob(Job job);
    }
}
