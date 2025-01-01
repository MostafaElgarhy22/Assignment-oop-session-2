using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public SecurityLevel SecurityPrivilege { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }




        public Employee2(int id, string name, char gender, SecurityLevel securityPrivilege, decimal salary, DateTime hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityPrivilege = securityPrivilege;
            Salary = salary;
            HireDate = hireDate;
        }


        public override string ToString()
        {
            return $"ID: {ID}, Name :{Name} , Gender : {Gender} , SecurityPrivilege : {SecurityPrivilege} , Salary : {Salary} , HireDate : {HireDate}";
        }





}
