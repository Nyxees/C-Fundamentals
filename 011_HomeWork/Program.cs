namespace _011_HomeWork
{
    delegate void MyDel(int m);

    class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }

        public event MyDel MarkChange;

        public Student(string name)
        {
            Name = name;
            Marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            Marks.Add(mark);
            MarkChange?.Invoke(mark);
        }
    }

    class Parent
    {
        public void OnMarkChange(int estimate)
        {
            Console.WriteLine($"New estimate received: {estimate}");
        }
    }

    class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 10)
                Console.WriteLine("Congratulations! You are eligible for a scholarship.");
            else
                Console.WriteLine("Sorry, you are not eligible for a scholarship.");
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student("John");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            // Subscribe the parent.OnMarkChange method to the MarkChange
            student.MarkChange += parent.OnMarkChange;

            // Subscribe the accountancy.PayingFellowship method
            student.MarkChange += accountancy.PayingFellowship;

            // Add marks 
            student.AddMark(10);
            student.AddMark(11);
            student.AddMark(12);
        }
    }
}