enum HTTPError
{
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402
}

struct Dog
{
    public string name;
    public string mark;
    public int age;

    public override string ToString()
    {
        return "Name: " + name + ", Mark: " + mark + ", Age: " + age;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        // 1 Task
        
        Console.Write("Enter the first number: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        float num3 = float.Parse(Console.ReadLine());

        bool allInRange = num1 >= -5.0 && num1 <= 5.0 && num2 >= -5.0 && num2 <= 5.0 && num3 >= -5.0 && num3 <= 5.0;

        if (allInRange)
        {
            Console.WriteLine("All numbers are in the range [-5, 5].");
        }
        else
        {
            Console.WriteLine("Not all numbers are in the range [-5, 5].");
        }

        // 2 Task

        Console.Write("Enter the first number: ");
        int Num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int Num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int Num3 = int.Parse(Console.ReadLine());

        int max = Math.Max(Num1, Math.Max(Num2, Num3));
        int min = Math.Min(Num1, Math.Min(Num2, Num3));

        Console.WriteLine("The maximum number is: " + max);
        Console.WriteLine("The minimum number is: " + min);

        // 3 Task

        Console.Write("Enter the number of an HTTP error (400, 401, or 402): ");
        int errorCode = int.Parse(Console.ReadLine());

        if (Enum.IsDefined(typeof(HTTPError), errorCode))
        {
            HTTPError error = (HTTPError)errorCode;
            Console.WriteLine("The error name is: " + error.ToString());
        }
        else
        {
            Console.WriteLine("Invalid error code entered.");
        }

        // 4 Task

        Dog myDog;
        Console.Write("Enter the dog's name: ");
        myDog.name = Console.ReadLine();
        Console.Write("Enter the dog's mark: ");
        myDog.mark = Console.ReadLine();
        Console.Write("Enter the dog's age: ");
        myDog.age = int.Parse(Console.ReadLine());

        Console.WriteLine(myDog.ToString());

    }
}