using API.Dtos;
using API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    // This class is for creating maps with automapper
    public class JobsProfile : Profile
    {
        public JobsProfile()
        {
            CreateMap<Job, JobReadByIdDto>();
            CreateMap<Job, JobsReadDto>();
            CreateMap<JobCreateDto, Job>();
            CreateMap<JobUpdateDto, Job>();
            CreateMap<Job, JobUpdateDto>();
        }
    }
}
