using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Job
    {
        private int _id;
        [Key]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _title;
        [Required]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private DateTime _creationDate;
        [Required]
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        private string _logo;

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        private string _companyName;
        [Required]
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _description;
        [Required]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _benefits;

        public string Benefits
        {
            get { return _benefits; }
            set { _benefits = value; }
        }

        private string _companyImage;

        public string CompanyImage
        {
            get { return _companyImage; }
            set { _companyImage = value; }
        }

        private string _email;
        [Required]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phone;
        
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _contactName;
        [Required]
        public string ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }

    }
}
