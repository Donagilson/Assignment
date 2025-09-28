using ConsoleAppEms2025.Model;

class Program
{
    static void Main(string[] args)
    {
        // ---- Student ----
        Console.WriteLine("Enter Student Details:");
        Console.Write("Name: ");
        string sName = Console.ReadLine();

        Console.Write("Student ID: ");
        int sId = int.Parse(Console.ReadLine());

        Console.Write("Major (Graduate / Post Graduate): ");
        string sMajor = Console.ReadLine();

        Student s1 = new Student(sName, sId, sMajor);
        s1.Study();

        // ---- Professor ----
        Console.WriteLine("\nEnter Professor Details:");
        Console.Write("Name: ");
        string pName = Console.ReadLine();

        Console.Write("Emp ID: ");
        int pId = int.Parse(Console.ReadLine());

        Console.Write("Major: ");
        string pMajor = Console.ReadLine();

        Professor p1 = new Professor(pName, pId, pMajor);
        p1.Teach();

        // ---- Course ----
        Console.WriteLine("\nEnter Course Details:");
        Console.Write("Title: ");
        string cTitle = Console.ReadLine();

        Console.Write("Duration (in hours): ");
        int cDuration = int.Parse(Console.ReadLine());

        Course c1 = new Course(cTitle, cDuration);
        c1.ShowCourse();

        Console.ReadLine();
    }
}
