using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class JobsReadDto
    {
        #region Fields

        private int _id;
        private string _title;
        private DateTime _creationDate;
        private string _logo;
        private string _companyName;
        private string _category;
        private string _city;
        private string _description;

        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [Required]
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        [Required]
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        [Required]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }        

        #endregion
    }
}
