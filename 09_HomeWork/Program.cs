namespace _09_HomeWork
{
    //--------------- HomeWork A
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    abstract class Shape : IComparable<Shape>
    {
        public string Name { get; }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            double thisArea = Area();
            double otherArea = other.Area();
            return thisArea.CompareTo(otherArea);
        }
    }

    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Square : Shape
    {
        public double Side { get; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
    //-------------- 1 Task
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>
        {
            new Circle("Circle 1", 5),
            new Square("Square 1", 7),
            new Circle("Circle 2", 8),
            new Square("Square 2", 10),
            new Circle("Circle 3", 12),
            new Square("Square 3", 15)
        };

            Console.WriteLine("Shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }
            //--------------- 2 Task
            var Range = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);

            using (StreamWriter writer = new StreamWriter("Range.txt"))
            {
                writer.WriteLine("Shapes with area in the range [10, 100]:");
                foreach (Shape shape in Range)
                {
                    writer.WriteLine($"Name: {shape.Name}");
                    writer.WriteLine($"Area: {shape.Area()}");
                    writer.WriteLine($"Perimeter: {shape.Perimeter()}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Shapes with area in the range [10, 100] written to file 'Range.txt'.");

            //-------------- 3 Task
            var ContainingA = shapes.Where(shape => shape.Name.Contains('a'));

            using (StreamWriter writer = new StreamWriter("ContainingA.txt"))
            {
                writer.WriteLine("Shapes with name containing the letter 'a':");
                foreach (Shape shape in ContainingA)
                {
                    writer.WriteLine($"Name: {shape.Name}");
                    writer.WriteLine($"Area: {shape.Area()}");
                    writer.WriteLine($"Perimeter: {shape.Perimeter()}");
                    writer.WriteLine();
                }
            }

            //-------------- 4 Task
            Console.WriteLine("Shapes with name containing the letter 'a' written to file 'ContainingA.txt'.");

            shapes.RemoveAll(shape => shape.Perimeter() < 5);

            Console.WriteLine("Shapes after removing shapes with perimeter less than 5:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }
        }
    }


    //-----------------HomeWork B
    class Program
    {
        static void Main()
        {
            // Specify the path
            string filePath = "path.txt";

            // Read all lines into an array of strings
            string[] lines = File.ReadAllLines(filePath);

            // Display each line 
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            //--------------Task 1
            Console.WriteLine("Number of symbols in each line:");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int symbolCount = line.Length;
                Console.WriteLine($"Line {i + 1}: {symbolCount} symbols");
            }
            Console.WriteLine();

            //---------------- 2 Task 2: Find the longest and the shortest line
            string longestLine = lines[0];
            string shortestLine = lines[0];
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Length > longestLine.Length)
                {
                    longestLine = line;
                }
                if (line.Length < shortestLine.Length)
                {
                    shortestLine = line;
                }
            }
            Console.WriteLine("Longest line:");
            Console.WriteLine(longestLine);
            Console.WriteLine("Shortest line:");
            Console.WriteLine(shortestLine);

            //---------------Task 3
            Console.WriteLine("Lines containing the word 'var':");
            foreach (string line in lines)
            {
                if (line.Contains("var"))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}