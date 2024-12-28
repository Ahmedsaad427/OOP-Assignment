using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
    }
}

struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class HiringDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HiringDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}

class Employee : IComparable<Employee>
{
    public enum SecurityLevel { Guest, Developer, Secretary, DBA }

    public int ID { get; set; }
    public string Name { get; set; }
    private char gender;
    public char Gender
    {
        get => gender;
        set
        {
            if (value != 'M' && value != 'F')
                throw new ArgumentException("Gender must be 'M' or 'F'.");
            gender = value;
        }
    }
    public double Salary { get; set; }
    public HiringDate HireDate { get; set; }
    public SecurityLevel Security { get; set; }

    public Employee(int id, string name, char gender, double salary, HiringDate hireDate, SecurityLevel security)
    {
        ID = id;
        Name = name;
        Gender = gender;
        Salary = salary;
        HireDate = hireDate;
        Security = security;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}, Hire Date: {HireDate}, Security Level: {Security}";
    }

    public int CompareTo(Employee other)
    {
        return (HireDate.Year, HireDate.Month, HireDate.Day).CompareTo((other.HireDate.Year, other.HireDate.Month, other.HireDate.Day));
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region Part 1-Q1 - Distance Between Points
        Console.WriteLine("Enter coordinates for the first point (X Y):");
        string[] input1 = Console.ReadLine().Split();
        Point p1 = new Point(double.Parse(input1[0]), double.Parse(input1[1]));

        Console.WriteLine("Enter coordinates for the second point (X Y):");
        string[] input2 = Console.ReadLine().Split();
        Point p2 = new Point(double.Parse(input2[0]), double.Parse(input2[1]));

        Console.WriteLine($"Distance between the two points: {p1.DistanceTo(p2):F2}");
        #endregion

        PartTwo();

        PartThree();
    }

    #region Part 1-Q2 - Oldest Person
    static void PartTwo()
    {
        // Input for three persons
        Person[] persons = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1} (Name Age):");
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);
            persons[i] = new Person(name, age);
        }

        // Find the oldest person
        Person oldest = persons[0];

        foreach (var person in persons)
        {
            if (person.Age > oldest.Age)
            {
                oldest = person;
            }
        }

        // Display the oldest person's details
        Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
    }
    #endregion

    #region Part 2 - Employee Management
    static void PartThree()
    {
        Employee[] employees = new Employee[3];

        employees[0] = new Employee(1, "Alice", 'F', 70000, new HiringDate(1, 5, 2020), Employee.SecurityLevel.DBA);
        employees[1] = new Employee(2, "Bob", 'M', 50000, new HiringDate(12, 3, 2021), Employee.SecurityLevel.Guest);
        employees[2] = new Employee(3, "Charlie", 'M', 100000, new HiringDate(15, 1, 2019), Employee.SecurityLevel.Developer);

        Array.Sort(employees);

        Console.WriteLine("Sorted Employees by Hire Date:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
    #endregion

    //The exact number of boxing/unboxing operations will depend on the specific sorting algorithm used by Array.Sort.In most cases, it performs O(n log n) comparisons, where n is the number of elements(in this case, 3). Thus, boxing and unboxing operations will occur roughly once per comparison, resulting in several boxing/unboxing operations during the sorting process.
}
