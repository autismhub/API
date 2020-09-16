using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobRepo _repository;

        public JobsController(IJobRepo repository)
        {
            _repository = repository;
        }

        // GET api/jobs
        [HttpGet]
        public ActionResult <IEnumerable<Job>> GetAllJobs()
        {
            IEnumerable<Job> jobItems = _repository.GetAllJobs();

            return Ok(jobItems);
        }

        // GET api/jobs/{id}
        [HttpGet("{id}")]
        public ActionResult <Job> GetJobById(int id)
        {
            Job jobItem = _repository.GetJobById(id);

            return Ok(jobItem);
        }
    }
}
