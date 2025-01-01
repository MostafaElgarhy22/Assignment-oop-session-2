using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private char gender { get; set; }

        public char Gender
        {
            get { return Gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    Gender = value;
                }
                else
                {
                    throw new Exception("Gender is M for male and F for female");  // we used here throw exception to show the error message .

                }
            }
        }
    

        public decimal salary { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public DateTime HireDate { get; set; }



        #region Constructor

        public Employee(int id , string Name , char gender , SecurityLevel securityLevel , decimal salary, DateTime HireDate)
        {
            ID = id;
            Name = Name;
            Gender = gender; 
            SecurityLevel = securityLevel;
            salary = salary;
            HireDate = HireDate;
        }

        public override string ToString()
        {
            return $"ID = {ID} ,Name = {Name},Gender = {Gender},SecurityLevel = {SecurityLevel},Salary = {salary},HireDate = {HireDate}";
            #endregion
        }
}


