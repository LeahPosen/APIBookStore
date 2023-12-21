namespace Store.Core.Entities
{
    public class Saler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Saler(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
}
