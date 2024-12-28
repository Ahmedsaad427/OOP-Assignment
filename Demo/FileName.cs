//using System;

//namespace Demo
//{
//    internal struct Point
//    {
//        public int X; // 4 bytes
//        public int Y; // 4 bytes

//        // Constructor: Special Method
//        // 1. Named like the struct (Point)
//        // 2. Has no return type
//        // CLR will generate a parameterless constructor by default
//        // This constructor will initialize the attributes with the default values.

//        // Optional: You can define a constructor to initialize the fields
//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        // Override ToString method for better display
//        public override string ToString()
//        {
//            return $"({X}, {Y})";
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Using the constructor to create a Point with specific values
//            Point p = new Point(5, 10);

//            // Displaying the Point using ToString method
//            Console.WriteLine($"Point: {p}");
//        }
//    }
//}
