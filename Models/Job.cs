using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    // Job entities is stored in the database with these properties
    public class Job
    {
        #region Fields

        private int _id;
        private string _title = new string(new char[250], 0, 250);
        private DateTime _creationDate;
        private string _logo = new string(new char[150], 0, 150);
        private string _companyName = new string(new char[200], 0, 200);
        private string _category = new string(new char[150], 0, 150);
        private string _city = new string(new char[150], 0, 150);
        private StringBuilder _description = new StringBuilder(1875, 15000);
        private string _benefits = new string(new char[250], 0, 250);
        private string _companyImage = new string(new char[150], 0, 150);
        private string _email = new string(new char[100], 0, 100);
        private string _phone = new string(new char[50], 0, 50);
        private string _address = new string(new char[150], 0, 150);
        private string _contactName = new string(new char[100], 0, 100);

        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        [MaxLength(250)]
        public string Title
        {
            get { return _title; }
            set 
            {
                try
                {
                    _title = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string in the title field is too long
                }
            }
        }

        [Required]
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set
            {
                _creationDate = DateTime.Now;
            }
        }

        [MaxLength(150)]
        public string Logo
        {
            get { return _logo; }
            set 
            { 
                try
                {
                    _logo = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The name of the logo image is too long
                }
            }
        }

        [Required]
        [MaxLength(200)]
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                try
                {
                    _companyName = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string in the company name is too long
                }
            }
        }

        [MaxLength(150)]
        public string Category
        {
            get { return _category; }
            set
            {
                try
                {
                    _category = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string in the category field is too long
                }
            }
        }

        [MaxLength(150)]
        public string City
        {
            get { return _city; }
            set
            {
                try
                {
                    _city = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string in the city field is too long
                }
            }
        }

        [Required]
        [MaxLength(15000)]
        public StringBuilder Description
        {
            get { return _description; }
            set
            {
                if (value.Length > _description.MaxCapacity)
                {
                    try
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        // Message: The value/string in the description field is too long
                    }
                }
                else
                {
                    _description = value;
                }
            }
        }

        [MaxLength(250)]
        public string Benefits
        {
            get { return _benefits; }
            set
            {
                try
                {
                    _benefits = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string in the benefits field is too long
                }
            }
        }

        [MaxLength(150)]
        public string CompanyImage
        {
            get { return _companyImage; }
            set
            {
                try
                {
                    _companyImage = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The name of the company image is too long
                }
            }
        }

        [Required]
        [MaxLength(100)]
        public string Email
        {
            get { return _email; }
            set
            {
                try
                {
                    _email = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string of the email field is too long
                }
            }
        }

        [MaxLength(50)]
        public string Phone
        {
            get { return _phone; }
            set
            {
                try
                {
                    _phone = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string of the phone field is too long
                }
            }
        }

        [MaxLength(150)]
        public string Address
        {
            get { return _address; }
            set
            {
                try
                {
                    _address = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string of the address field is too long
                }
            }
        }

        [Required]
        [MaxLength(100)]
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                try
                {
                    _contactName = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Message: The value/string of the contact name field is too long
                }
            }
        }

        #endregion
    }
}
