using System;
using System.Collections.Generic;
using RealEstateManagement.Estates;   // ✅ Correct namespace for Estate

namespace RealEstateManagement.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string TaxID { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Estate> EstatesForSale { get; set; }

        public Company(string name, string owner, string taxId)
        {
            Name = name;
            Owner = owner;
            TaxID = taxId;
            Employees = new List<Employee>();
            EstatesForSale = new List<Estate>();
        }

        public void AddEmployee(Employee e) => Employees.Add(e);
        public void AddEstate(Estate e) => EstatesForSale.Add(e);

        public void DisplayCompanyInfo()
        {
            Console.WriteLine($"Company: {Name}, Owner: {Owner}, TaxID: {TaxID}");
            Console.WriteLine("Employees:");
            foreach (var emp in Employees) Console.WriteLine(" - " + emp);
            Console.WriteLine("Estates for Sale:");
            foreach (var estate in EstatesForSale) estate.DisplayDetails();
        }
    }
}
