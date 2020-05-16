using System;
namespace MiniProject3
{
    public class Book
    {
        public string name { get; }

        public float price { get; }

        public Book(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Book name:{name} price:{price}";
        }
    }
}
