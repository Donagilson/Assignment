namespace RealEstateManagement.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string position, int experience)
        {
            Name = name;
            Position = position;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"{Name} ({Position}, {Experience} years exp.)";
        }
    }
}
