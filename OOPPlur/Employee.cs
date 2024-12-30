using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlur
{
    internal class Employee
    {
        public int Id;
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime BirthDay;
        const int minimalHoursWorkunit = 1;

        public EmployeeType employeeType;
        public Employee(string first, string last, string em, DateTime bd):this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {

        }
        public Employee (string first, string last, string em, DateTime bd, double rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            BirthDay= bd;
            hourlyRate = rate;
            employeeType = empType;
        }
        //public Employee() { }

        //public Employee(string first, string last, string em, DateTime bd, double rate)
        //{
        //    // create a new instance.
        //   firstName = first;
        //    lastName = last;
        //    email = em;
        //    hourlyRate = rate;
        //}


        public void PerformWork()
        {
            PerformWork(minimalHoursWorkunit);
            //numberOfHoursWorked++;
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours.");
        }
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s) of work.");
        }
        public int calculateBouns(int bouns)
        {
            if (numberOfHoursWorked > 10)
            {
                bouns *= 2;
                Console.WriteLine($"Bouns is {bouns}");
                return bouns;
            }
            else
            {
                return 0;
            }
        }

        public int calculateBounsAndBounsTax(int bouns, ref int bounsTax)
        {
            if(numberOfHoursWorked > 10)
            {
                bouns *= 2;
            }
            if(bouns >= 200)
            {
                bounsTax = bouns / 10;
                bouns -= bounsTax; 
            }
            Console.WriteLine($"{bouns} and bouns tax is{bounsTax}");
            return bouns;
        }
        public static void usingAcutomTrype()
        {
            List<string> list = new List<string>();
        }
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public double ReceiveWage( bool restHours = true)
        {
            if(employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An Extra was added to the wage since {firstName} is a manager!");
                wage = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked}  hour(s) of work.");
            if(restHours)
            {
                numberOfHoursWorked = 0;
            }
            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\n First Name: {firstName} \n Last Name: {lastName}" +
                $"Email: \t{email} \t{BirthDay.ToShortDateString()}");
        }

    }
    }

