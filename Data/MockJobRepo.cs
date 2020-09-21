using API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class MockJobRepo : IJobRepo
    {
        public IEnumerable<Job> GetAllJobs()
        {
            List<Job> jobs = new List<Job>
            {
                new Job{Id=0, Address="Carl gustavsgade 3, Høje Taastrup", Benefits="Free coffee/tea", Category="Back-end Developer", City="Høje Taastrup", CompanyImage="AspIT.jpg", CompanyName="AspIT", ContactName="Bo Jørgensen", CreationDate=new DateTime(2020, 09, 15), Description="Description", Email="example@gmail.com", Logo="Logo.png", Phone="12345678", Title="ASP DOTNET Core Back-end developer"},
                new Job{Id=1, Address="Solvej 16B, Ishoej", Benefits="Possibilities for public transport", Category="Media designer", City="Ishoej", CompanyImage="TheCoders.jpg", CompanyName="The Coders", ContactName="Hans Mikkelsen", CreationDate=new DateTime(2015, 03, 06), Description="Description", Email="example@edu.campusvejle.dk", Logo="Logo.png", Phone="87654321", Title="Designer for big data companies"},
                new Job{Id=2, Address="Nørregade 7, Copenhagen", Benefits="Private workspace", Category="IT-supporter", City="Copenhagen", CompanyImage="WindowsSupport.jpg", CompanyName="Windows Support", ContactName="Preben Sveskehud", CreationDate=new DateTime(2020, 09, 15), Description="Description", Email="example@live.dk", Logo="Logo.png", Phone="11223344", Title="IT support and maintainance"}
            };
            return jobs;
        }

        public Job GetJobById(int id)
        {
            return new Job {Id=0, Address="Carl gustavsgade 3, Høje Taastrup", Benefits="Free coffee/tea", Category="Back-end Developer", City="Høje Taastrup", CompanyImage="AspIT.jpg", CompanyName="AspIT", ContactName="Bo Jørgensen", CreationDate=new DateTime(2020, 09, 15), Description="Description", Email="example@gmail.com", Logo="Logo.png", Phone="12345678", Title="ASP DOTNET Core Back-end developer"};
        }
    }
}
