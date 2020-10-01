using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dtos
{
    // This is the response when getting a job by id
    public class JobReadByIdDto
    {
        #region Fields

        private readonly int _id;
        private readonly string _title = new string(new char[250], 0, 250);
        private readonly DateTime _creationDate;
        private readonly string _logo = new string(new char[150], 0, 150);
        private readonly string _companyName = new string(new char[200], 0, 200);
        private readonly string _category = new string(new char[150], 0, 150);
        private readonly string _city = new string(new char[150], 0, 150);
        private readonly StringBuilder _description = new StringBuilder(1875, 15000);
        private readonly string _benefits = new string(new char[250], 0, 250);
        private readonly string _companyImage = new string(new char[150], 0, 150);
        private readonly string _email = new string(new char[100], 0, 100);
        private readonly string _phone = new string(new char[50], 0, 50);
        private readonly string _address = new string(new char[150], 0, 150);
        private readonly string _contactName = new string(new char[100], 0, 100);

        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return _id; }
        }

        [Required]
        [MaxLength(250)]
        public string Title
        {
            get { return _title; }
        }

        [Required]
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        [MaxLength(150)]
        public string Logo
        {
            get { return _logo; }
        }

        [Required]
        [MaxLength(200)]
        public string CompanyName
        {
            get { return _companyName; }
        }

        [MaxLength(150)]
        public string Category
        {
            get { return _category; }
        }

        [MaxLength(150)]
        public string City
        {
            get { return _city; }
        }

        [Required]
        [MaxLength(15000)]
        public StringBuilder Description
        {
            get { return _description; }
        }

        [MaxLength(250)]
        public string Benefits
        {
            get { return _benefits; }
        }

        [MaxLength(150)]
        public string CompanyImage
        {
            get { return _companyImage; }
        }

        [Required]
        [MaxLength(100)]
        public string Email
        {
            get { return _email; }
        }

        [MaxLength(50)]
        public string Phone
        {
            get { return _phone; }
        }

        [MaxLength(150)]
        public string Address
        {
            get { return _address; }
        }

        [Required]
        [MaxLength(100)]
        public string ContactName
        {
            get { return _contactName; }
        }

        #endregion
    }
}
