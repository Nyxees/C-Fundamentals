internal class Program
{
    private static void Main(string[] args)
    {
        // 1 Task
        int a;
        Console.Write("Enter the side length of the square: ");
        a = int.Parse(Console.ReadLine());

        int area = a * a;
        int perimeter = 4 * a;

        Console.WriteLine("The area of the square is " + area);
        Console.WriteLine("The perimeter of the square is " + perimeter);

        // 2 Task
        string name;
        int age;

        Console.Write(" What is your name? ");
        name = Console.ReadLine();

        Console.Write($"How old are you, {name}? ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");

        // 3 Task
        double r;

        Console.Write("Enter the radius of the circle: ");
        r = double.Parse(Console.ReadLine());

        double pi = Math.PI;
        double length = 2 * pi * r;
        double CircleArea = pi * r * r;
        double volume = 4.0 / 3.0 * pi * r * r * r;

        Console.WriteLine("The length of the circle is " + length);
        Console.WriteLine("The area of the circle is " + CircleArea);
        Console.WriteLine("The volume of the circle is " + volume);
    }
}