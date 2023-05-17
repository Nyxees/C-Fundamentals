namespace _06_HomeWork
{
    //-------------------- 1 Task
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = ReadInt("Enter the first number: ");
                int b = ReadInt("Enter the second number: ");
                int result = Div(a, b);
                Console.WriteLine($"Result of division: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        //--------------------- 2 TAsk
        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        //--------------- 3 Task
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[10];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = ReadNumber(1, 100);
                }

                Console.WriteLine("Entered numbers:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int ReadNumber(int start, int end)
        {
            while (true)
            {
                Console.Write($"Enter a number between {start} and {end}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number >= start && number <= end)
                    {
                        return number;
                    }
                }
                Console.WriteLine("Invalid input. Please enter a valid number within the specified range.");
            }
        }
    }
}
