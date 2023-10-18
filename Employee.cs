using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric
{

    class Employee
    {
        private string _name;
        private int _id;
        private int _salary;
        private string _gender;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}, Salary: {Salary}, Gender: {Gender}";
        }
    }
}

