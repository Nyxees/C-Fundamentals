namespace _08_HomeWork
{
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

    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter details for Shape {i}:");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Select shape type: ");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Square");
                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                Shape shape;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        shape = new Circle(name, radius);
                        break;
                    case 2:
                        Console.Write("Enter side length: ");
                        double side = double.Parse(Console.ReadLine());
                        shape = new Square(name, side);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Skipping shape...");
                        continue;
                }

                shapes.Add(shape);
            }

            Console.WriteLine();
            Console.WriteLine("Shapes (unsorted):");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }

            shapes.Sort();

            Console.WriteLine("Shapes (sorted by area):");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }
        }
    }
}