namespace _03_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------- 1 Task


            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            int aCount = 0, oCount = 0, iCount = 0, eCount = 0;

            foreach (char c in str.ToLower())
            {
                if (c == 'a') aCount++;
                if (c == 'o') oCount++;
                if (c == 'i') iCount++;
                if (c == 'e') eCount++;
            }

            Console.WriteLine($"Count of 'a' in the string: {aCount}");
            Console.WriteLine($"Count of 'o' in the string: {oCount}");
            Console.WriteLine($"Count of 'i' in the string: {iCount}");
            Console.WriteLine($"Count of 'e' in the string: {eCount}");

            //---------- 2 Task

            Console.Write("Enter the number of a month: ");
            int month = int.Parse(Console.ReadLine());

            int days = 0;

            switch (month)
            {
                case 2:
                    days = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 31;
                    break;
            }

            Console.WriteLine($"Number of days in month {month}: {days}");

            //----------- 3 Task

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter integer number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            long product = 1;
            bool firstFivePositive = true;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] < 0)
                {
                    firstFivePositive = false;
                    break;
                }
                sum += numbers[i];
            }

            if (firstFivePositive)
            {
                Console.WriteLine("The sum of first 5 positive numbers is: {0}", sum);
            }
            else
            {
                for (int i = 5; i < 10; i++)
                {
                    product *= numbers[i];
                }
                Console.WriteLine("The product of last 5 numbers is: {0}", product);

            }
        }
    }
}