namespace AutoPartsStore.Models
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Manufacturer(string name, string country, string address, string phone, string fax)
        {
            Name = name;
            Country = country;
            Address = address;
            Phone = phone;
            Fax = fax;
        }

        public override string ToString()
        {
            return $"{Name}, {Country}, {Address}, Phone: {Phone}, Fax: {Fax}";
        }
    }
}
