using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of numbers:");
            int sum = numbers.Sum();
            Console.WriteLine(sum);

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine(  );

            //TODO: Print the Average of numbers

            Console.WriteLine("Average of numbers:");
            int avg = (int)numbers.Average();
            Console.WriteLine(avg);

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Numbers in ascending order:");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("Numbers in descending order:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers greater than 6:");
            numbers.Where(x => x > 6).ToList().ForEach(numbers => Console.WriteLine(numbers));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only 4 numbers (acsending or descending)");
            numbers.Where(x => x < 9 && x > 4).ToList().ForEach(numbers => Console.WriteLine(numbers));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Change index 4 to your age, then print the numbers in decsending order");
            numbers[4] = 33;
            numbers.OrderByDescending(x => x).ToList().ForEach(numbers => Console.WriteLine(numbers));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            Console.WriteLine("~~~PT. 2~~~");
            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Employees that start with 'C' or 'S'");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).
                ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the
            //console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees over the age of 26 by full name");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} - {x.Age}"));

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if
            //their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Sum of employees' Years of experience");
             var sumYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(sumYOE);
            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            Console.WriteLine("Average of employees' Years of experience");
            var avgYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(avgYOE);

            Console.WriteLine();
            Console.WriteLine("~~~~~~");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add() 

            Console.WriteLine("Add employee without using employees.Add()");
            var adam = new Employee();
            adam.FirstName = "Adam";
            adam.LastName = "Measel";
            adam.YearsOfExperience = 1;
            adam.Age = 33;

            employees.Append(adam).ToList().ForEach(x => Console.WriteLine($"~~~~\nName: {x.FullName}\nAge: {x.Age}\nYears of Experience: {x.YearsOfExperience}"));


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            





            return employees;
        }
        #endregion
    }
}
