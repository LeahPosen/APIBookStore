namespace Store.Core.Entities
{
    public class Branch
    {
        public int id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int CountOfSalers { get; set; }
        public Branch(int id, string city, string street, int countOfSalers)
        {
            this.id = id;
            City = city;
            Street = street;
            CountOfSalers = countOfSalers;
        }
    }
}
