namespace Challenge_Lab_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new();

            Console.Write("Input the Roll Number of the Student: ");
            student.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Input the Marks of Physics, Chemistry, and Computer Application: ");
            student.PhysicsMarks = Convert.ToInt32(Console.ReadLine());
            student.ChemistryMarks = Convert.ToInt32(Console.ReadLine());
            student.ComputerApplicationMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(student.ToString());
        }
    }

    public class Student
    {
        public int RollNo { get; set; }
        public string? Name { get; set; }
        public int PhysicsMarks { get; set; }
        public int ChemistryMarks { get; set; }
        public int ComputerApplicationMarks { get; set; }
        public int TotalMarks
        {
            get
            {
                return PhysicsMarks + ChemistryMarks + ComputerApplicationMarks;
            }
        }
        public double Average
        {
            get
            {
                return (double)TotalMarks / 3;
            }
        }
        // Division classifications obtained from https://aonecollege.co.in/course-offered/classification-of-divisions
        public string Division
        {
            get
            {
                switch (Average)
                {
                    case >= 60:
                        return "First";
                    case >= 50 and < 60:
                        return "Second";
                    default:
                        return "Third";
                }
            }
        }
        public override string ToString()
        {
            return $"Roll No: {RollNo}\n" +
                $"Name of Student: {Name}\n" +
                $"Marks in Physics: {PhysicsMarks}\n" +
                $"Marks in Chemistry: {ChemistryMarks}\n" +
                $"Marks in Computer Application: {ComputerApplicationMarks}\n" +
                $"Total Marks: {TotalMarks}\n" +
                $"Percentage: {Average}\n" +
                $"Divison: {Division}";
        }
    }
}
