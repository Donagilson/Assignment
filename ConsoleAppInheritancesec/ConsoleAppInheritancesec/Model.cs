namespace ConsoleAppEms2025.Model
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double BasicPay { get; set; }

        public Employee(int empNo, string name, string designation, double basicPay)
        {
            EmpNo = empNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public virtual void Display()
        {
            Console.WriteLine($"EmpNo: {EmpNo}, Name: {Name}, Designation: {Designation}, BasicPay: {BasicPay}");
        }
    }

    public class Executive : Employee
    {
        public Executive(int empNo, string name, string designation, double basicPay)
            : base(empNo, name, designation, basicPay)
        {
            if (basicPay <= 10000)
            {
                throw new ArgumentException("Executive must have BasicPay greater than 10000!");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"[Executive] EmpNo: {EmpNo}, Name: {Name}, Designation: {Designation}, BasicPay: {BasicPay}");
        }
    }
}
