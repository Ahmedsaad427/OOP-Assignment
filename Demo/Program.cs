//using System;

//internal class Program
//{
//    static void Main()
//    {
//        #region Struct
//        // Declare and initialize the Point struct with X and Y values
//        Point P01 = new Point(12, 12); // Initialize with values

//        // Access and display the X and Y coordinates
//        Console.WriteLine($"X: {P01.X}, Y: {P01.Y}");

//        // Modifying the values
//        P01.X = 15;
//        P01.Y = 20;

//        // Display the updated values
//        Console.WriteLine($"Updated X: {P01.X}, Updated Y: {P01.Y}");
//        #endregion

//        #region OOP
//        // OOP: Object-Oriented Programming
//        // Programming Paradigm used for building any business application
//        //
//        // Class: Blueprint of an object
//        // Object: Specific instance created from a class
//        //
//        // 4 Pillars of OOP:
//        // 1. Encapsulation
//        // 2. Inheritance
//        // 3. Polymorphism
//        // 4. Abstraction
//        #endregion

//        #region Encapsulation

//        // 1. Encapsulation:
//        // Class or Struct
//        // Separate the Data (Attributes) Definition from Its Use
//        // Apply Encapsulation:
//        // 1. Make All Data (Attributes) Private
//        // 2. Access Data Through:
//        // 2.1. Setter Getter Method
//        // 2.2. Properties
//        Employee E01 = new Employee();

//        // Setting values using setter methods
//        //E01.SetId(1);
//        //E01.SetName("Ahmed");
//        //E01.SetSalary(12000);

//        // Displaying values using getter methods
//        //Console.WriteLine(E01.GetId());
//        //Console.WriteLine(E01.GetName());
//        //Console.WriteLine(E01.GetSalary());

//        #endregion

//        #region Encapsulation User Prp

//        // Example of using **Properties** for Encapsulation:

//        // Creating an Employee object using properties
//        //Employee E02 = new Employee();
//        //E02.Id = 2;          // Using property to set the value
//        //E02.Name = "Sara";    // Using property to set the value
//        //E02.Salary = 15000;   // Using property to set the value

//        // Accessing the values using properties
//        //Console.WriteLine($"Employee Id: {E02.Id}");
//        //Console.WriteLine($"Employee Name: {E02.Name}");
//        //Console.WriteLine($"Employee Salary: {E02.Salary}");

//        // Properties provide an alternative to getter and setter methods for encapsulation,
//        // allowing a more elegant syntax for accessing and modifying object data.
//        #endregion

//        #region Indexer

//        // 3. Indexer:
//        // Indexers allow an object to be indexed like an array.
//        // They provide a way to access the elements of a collection or array-like structure
//        // in a class or struct without needing explicit methods.
//        // Example: You can index into a collection and retrieve data like you would with an array.

//        // Defining an indexer in the StudentGrades class
//        StudentGrades grades = new StudentGrades();

//        // Setting grades using the indexer
//        grades["Math"] = 90;
//        grades["Science"] = 85;
//        grades["English"] = 88;

//        // Accessing grades using the indexer
//        Console.WriteLine($"Math Grade: {grades["Math"]}");
//        Console.WriteLine($"Science Grade: {grades["Science"]}");
//        Console.WriteLine($"English Grade: {grades["English"]}");

//        // In the above example, the StudentGrades class uses an indexer to store and retrieve
//        // the grades for specific subjects, allowing for cleaner syntax and easier access.

//        #endregion

//        #region Class-internal-constructor-chaining

//        // Constructor Chaining in Class
//        Console.WriteLine("\n--- Constructor Chaining Example ---");

//        // Creating objects using different constructors
//        Employee employee1 = new Employee(); // Default constructor
//        employee1.DisplayDetails();

//        Employee employee2 = new Employee(1); // Constructor with ID only
//        employee2.DisplayDetails();

//        Employee employee3 = new Employee(2, "Ahmed"); // Constructor with ID and Name
//        employee3.DisplayDetails();

//        Employee employee4 = new Employee(3, "Sara", 12000.0); // Constructor with all parameters
//        employee4.DisplayDetails();

//        #endregion
//    }
//}

//#region Struct for Point
//public struct Point
//{
//    public int X; // 4 bytes
//    public int Y; // 4 bytes

//    // Constructor to initialize the Point struct
//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}
//#endregion

//#region Class for Employee with Encapsulation
//public class Employee
//{
//    private int id;
//    private string name;
//    private double salary;

//    // Default constructor (no parameters)
//    public Employee() : this(0, "Unknown", 0.0) // Calling another constructor
//    {
//        Console.WriteLine("Default Constructor Called");
//    }

//    // Constructor with id parameter
//    public Employee(int id) : this(id, "Unknown", 0.0) // Calling another constructor
//    {
//        Console.WriteLine("Constructor with ID Called");
//    }

//    // Constructor with id and name parameters
//    public Employee(int id, string name) : this(id, name, 0.0) // Calling another constructor
//    {
//        Console.WriteLine("Constructor with ID and Name Called");
//    }

//    // Constructor with all parameters
//    public Employee(int id, string name, double salary)
//    {
//        this.id = id;
//        this.name = name;
//        this.salary = salary;
//        Console.WriteLine("Constructor with All Parameters Called");
//    }

//    // Method to display employee details
//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Employee ID: {id}, Name: {name}, Salary: {salary}");
//    }
//}

//#endregion

//#region Indexer Example: StudentGrades Class

//public class StudentGrades
//{
//    // Using a dictionary to store subject grades
//    private Dictionary<string, int> grades = new Dictionary<string, int>();

//    // Indexer to get or set the grade for a specific subject
//    public int this[string subject]
//    {
//        get
//        {
//            // If the subject exists, return the grade; otherwise, return 0
//            return grades.ContainsKey(subject) ? grades[subject] : 0;
//        }
//        set
//        {
//            // Set the grade for the given subject
//            grades[subject] = value;
//        }
//    }
//}

//#endregion
