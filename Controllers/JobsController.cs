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
        [HttpGet("{id}", Name="GetJobById")]
        public ActionResult <JobReadByIdDto> GetJobById(int id)
        {
            Job jobItem = _repository.GetJobById(id);

            if(jobItem != null)
            {
                return Ok(_mapper.Map<JobReadByIdDto>(jobItem));
            }
            return NotFound();
        }

        // POST api/jobs
        [HttpPost]
        public ActionResult <JobReadByIdDto> AddJob(JobCreateDto jobAddDto)
        {
            Job jobModel = _mapper.Map<Job>(jobAddDto);
            _repository.AddJob(jobModel);
            _repository.SaveChanges();

            var jobReadByIdDto = _mapper.Map<JobReadByIdDto>(jobModel);

            return CreatedAtRoute(nameof(GetJobById), new {Id = jobReadByIdDto.Id}, jobReadByIdDto);
        }
    }
}
