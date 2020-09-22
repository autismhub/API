using API.Dtos;
using API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class JobsProfile : Profile
    {
        public JobsProfile()
        {
            CreateMap<Job, JobReadByIdDto>();
            CreateMap<Job, JobsReadDto>();
            CreateMap<JobCreateDto, Job>();
            CreateMap<JobUpdateDto, Job>();
        }
    }
}
