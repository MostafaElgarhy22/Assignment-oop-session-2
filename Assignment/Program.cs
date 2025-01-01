﻿using System.Drawing;
using System.Reflection;

namespace Assignment
{


    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class Program
    {
        #region Part 01
        #region Q 1
        //static void Main(string[] args)
        //{
        //    Person[] arrayOfPerson = new Person[4];
        //    arrayOfPerson[0] = new Person(21, "Mostafa");
        //    arrayOfPerson[1] = new Person(22, "Ahmed");
        //    arrayOfPerson[2] = new Person(23, "Ali");
        //    arrayOfPerson[3] = new Person(24, "Mohamed");

        //   foreach(var Person  in arrayOfPerson)
        //    {
        //        Console.WriteLine($" Name = {Person.Name} , Age = {Person.Age}");
        //    }
        //}
        #endregion
        #region Q 2

        //static double CalculateDistance(Point p1, Point p2)
        //{

        //    double dx = p2.x - p1.x;
        //    double dy = p2.y - p1.y;
        //    return Math.Sqrt(dx * dx + dy * dy);
        //    // this is the library of math to solve the problem and the law is searched for it.

        //    Console.WriteLine($"the distance betwwen 2 numbers is {dx},{dy}");



        //    Point p1 = new Point(dx, dy);
        //    Console.WriteLine("Enter the numbers of first point : ");
        //    Console.WriteLine("X1 is :");
        //    p1.x = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Y1 is :");
        //    p1.y = Convert.ToDouble(Console.ReadLine());



        //    Point p2 = new Point(dx, dy);
        //    Console.WriteLine("Enter the numbers of first point : ");
        //    Console.WriteLine("X2 is :");
        //    p2.x = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Y2 is :");
        //    p2.y = Convert.ToDouble(Console.ReadLine());





        //}
        #endregion
        #region Q 3

        //    Person2[] Persons = new Person2[3];

        //    for(int i = 0; i < 3; i++)
        //    {
        //        Persons[i] = new Person2();
        //    Console.WriteLine("Enter the name of the person : ");
        //        Persons[i].Name = Console.ReadLine();
        //        Console.WriteLine("Enter the age of the person : ");
        //        Persons[i].Age = Convert.ToInt32(Console.ReadLine());
        //    }

        //for (int i = 1; i< 3; i++)
        //    {
        //    if (Persons[i].Age > Persons[0].Age)
        //    {
        //        Person2 temp = Persons[0];
        //Persons[0] = Persons[i];
        //        Persons[i] = temp;
        //    }
        //}

        //Console.WriteLine("The oldest person is : ");




        #endregion
        #endregion
        #region Part 02
        #region Q 1

        //Employee employeee3 = new Employee(1, "Mostafa", 'M', SecurityLevel.Developer, 10000, new DateTime(2020, 1, 1));

        //Console.WriteLine(employeee3.ToString());

        #endregion
        #region Q 2

        //HiringDate hiringDate = new HiringDate(2019, 8, 25);
        //Console.WriteLine(hiringDate.ToString());
        #endregion
        #region Q 3

        // we made this 2 classes before so i just call them .......


        //Employee[] employees = new Employee[2];

        //employees[0] = new Employee(1, "Mostafa", 'M', SecurityLevel.Developer, 10000, new DateTime(2020, 1, 1));
        //employees[1] = new Employee(2, "Ahmed", 'M', SecurityLevel.DBA, 20000, new DateTime(2020, 1, 1));


        //foreach (var employee in employees)
        //{
        //    Console.WriteLine(Employee);
        //}

        #endregion
        #region Q 4
        Employee2[] employees = new Employee2[4];

        employees[0] = new Employee2(1, "Mostafa", 'M', SecurityLevel.Developer, 10000, new DateTime(2020, 1, 1));
        employees[1] = new Employee2(2, "Ahmed", 'M', SecurityLevel.DBA, 20000, new DateTime(2020, 1, 1));
        employees[2] = new Employee2(3, "Ali", 'M', SecurityLevel.Secretary, 30000, new DateTime(2020, 1, 1));
        employees[3] = new Employee2(4, "Mohamed", 'M', SecurityLevel.SecurityOfficer, 40000, new DateTime(2020, 1, 1));


        Array.Sort(employees, (x, y) => x.Salary.CompareTo(y.Salary)); // this is the sorting method to sort the array of employees by salary

       
        foreach (var employee in employees)
        {
            Console.WriteLine(emp);
        }
    
    #endregion
    #endregion

}
}
