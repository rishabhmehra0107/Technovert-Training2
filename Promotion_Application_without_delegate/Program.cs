﻿using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<Employee> emplist = new List<Employee>();
        emplist.Add(new Employee() { ID = 1, Salary = 5000, Experience = 5 });
        emplist.Add(new Employee() { ID = 2, Salary = 3000, Experience = 3 });
        emplist.Add(new Employee() { ID = 3, Salary = 2000, Experience = 2 });
        emplist.Add(new Employee() { ID = 4, Salary = 6000, Experience = 6 });
        Employee.Promote(emplist);

    }
}
class Employee
{
    public int ID { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void Promote(List<Employee> emplt)
    {
        foreach (Employee emp in emplt)
        {
            if (emp.Experience >= 5)
                Console.WriteLine(emp.ID+" PROMOTED");
        }
    }

}
