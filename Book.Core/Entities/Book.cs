namespace Store.Core.Entities
{
    public enum Type { Adult, Teen, Kids, Comix };
    public class Book
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public double Price { get; set; }
        public Type Type { get; set; }
        public Book(int code, string title, string writer, double price, Type type)
        {
            Code = code;
            Title = title;
            Writer = writer;
            Price = price;
            Type = type;
        }
    }
}
