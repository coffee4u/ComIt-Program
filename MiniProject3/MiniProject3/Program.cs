using System;
using System.Collections.Generic;

namespace MiniProject3
{
    class Program
    {
        static List<Book> bookStore;

        static void Main(string[] args)
        {
            Console.WriteLine("Prepare Some Books");
            CreateBookStore();

            Console.WriteLine("Create a Person with Some Money");
            Person p1 = new Person("Tim");
            p1.DepositMoney(50);
            p1.BuyABook(bookStore[0]);
            p1.BuyABook(bookStore[1]);
            p1.BuyABook(bookStore[2]);

            p1.DepositMoney(1000);
            p1.BuyABook(bookStore[4]);

            Console.WriteLine("See What I have now:");
            Console.WriteLine(p1.ToString());
        }

        static void CreateBookStore()
        {
            bookStore = new List<Book>();
            Book one = new Book("one", 10);
            Book two = new Book("two", 15);
            Book three = new Book("three", 30);
            Book four = new Book("four", 50);
            Book five = new Book("five", 100);
            bookStore.Add(one);
            bookStore.Add(two);
            bookStore.Add(three);
            bookStore.Add(four);
            bookStore.Add(five);
        }
    }
}
