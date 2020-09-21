using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobRepo _repository;
        private readonly IMapper _mapper;

        public JobsController(IJobRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/jobs
        [HttpGet]
        public ActionResult <IEnumerable<JobsReadDto>> GetAllJobs()
        {
            IEnumerable<Job> jobItems = _repository.GetAllJobs();

            return Ok(_mapper.Map<IEnumerable<JobsReadDto>>(jobItems));
        }

        // GET api/jobs/{id}
        [HttpGet("{id}")]
        public ActionResult <JobReadByIdDto> GetJobById(int id)
        {
            Job jobItem = _repository.GetJobById(id);

            if(jobItem != null)
            {
                return Ok(_mapper.Map<JobReadByIdDto>(jobItem));
            }
            return NotFound();
        }
    }
}
