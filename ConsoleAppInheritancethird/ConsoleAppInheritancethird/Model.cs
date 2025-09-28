namespace ConsoleAppEms2025.Model
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public string Major { get; set; } // Graduate / Post Graduate

        public Student(string name, int studentId, string major)
        {
            Name = name;
            StudentId = studentId;
            Major = major;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} (ID: {StudentId}) is studying {Major}.");
        }
    }

    public class Professor
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public string Major { get; set; }

        public Professor(string name, int empId, string major)
        {
            Name = name;
            EmpId = empId;
            Major = major;
        }

        public void Teach()
        {
            Console.WriteLine($"Professor {Name} (EmpID: {EmpId}) is teaching {Major}.");
        }
    }

    public class Course
    {
        public string Title { get; set; }
        public int Duration { get; set; } // in hours/days

        public Course(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public void ShowCourse()
        {
            Console.WriteLine($"Course: {Title}, Duration: {Duration} hours.");
        }
    }
}
