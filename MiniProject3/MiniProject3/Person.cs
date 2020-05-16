using System;
using System.Collections.Generic;
namespace MiniProject3
{
    public class Person
    {
        string name;
        BankAccount bankAccount;
        List<Book> myBooks;
        public Person(string name)
        {
            this.name = name;
            bankAccount = new BankAccount();
            myBooks = new List<Book>();
        }

        public void DepositMoney(float money)
        {
            bankAccount.Deposit(money);
            Console.WriteLine($"I got {money} dollar");
        }

        public bool WithDrawMoney(float money)
        {
            bool isSucess = false;
            try
            {
                bankAccount.Withdraw(money);
                isSucess = true;
                Console.WriteLine($"Withdraw {money} dollar from my Bank");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return isSucess;
        }

        public void BuyABook(Book book)
        {
            Console.WriteLine($"Want Buy a New Book:{book.name} price:{book.price}");
            if(WithDrawMoney(book.price))
            {
                Book myNewBook = new Book(book.name, book.price);
                myBooks.Add(myNewBook);
                Console.WriteLine($"Success! I Got a new Book <{book.name}> with {book.price} spent");
            }
            else
            {
                Console.WriteLine("The book is too expensive!");

            }
        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"BankAccount: {bankAccount.ToString()}\n" +
                $"Books:\n" +
                $"{String.Join(",\n", myBooks)}"; 
        }
    }
}
