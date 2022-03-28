using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class GenericIndexers
    {
        public void Start()
        {
            Book firstBook = new Book("Pro C# 7.0", "Troelsen", 670);
            Book secondBook = new Book("CLR via C#", "Richter", 800);
            Book thirdBook = new Book("Learning Python", "LGBT", 100);

            BookShop myBookShop = new BookShop();
            myBookShop[700] = firstBook;
            myBookShop[900] = secondBook;
            myBookShop[500] = thirdBook;

            Employee firstEmployee = new Employee(400);
            Employee secondEmployee = new Employee(600);
            myBookShop["Vasya"] = firstEmployee;
            myBookShop["Petya"] = secondEmployee;

            foreach(KeyValuePair<int, Book> b in myBookShop)
            {
                Console.WriteLine(b);
            }

            foreach(KeyValuePair<string, Employee> e in myBookShop.employeeList)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
        }
    }

    class BookShop : IEnumerable
    {
        Dictionary<int, Book> bookList = new Dictionary<int, Book>();
        public Dictionary<string, Employee> employeeList = new Dictionary<string, Employee>();

        // NOTE: We also can set indexer in interface
        public Book this[int cost]
        {
            get => bookList[cost];
            set => bookList[cost] = value;
        }
        public Employee this[string name]
        {
            get => employeeList[name];
            set => employeeList[name] = value;
        }

        IEnumerator IEnumerable.GetEnumerator() => bookList.GetEnumerator();
    }

    class Book
    {
        public readonly string bookName;
        public readonly string author;
        public readonly int pages;

        public override string ToString()
        {
            return $"Book Name: {bookName}\nAuthor: {author}\nPages count: {pages}\n================";
        }

        public Book(string bookName_, string author_, int pagesCount)
        {
            bookName = bookName_;
            author = author_;
            pages = pagesCount;
        }
    }
    class Employee
    {
        public readonly int salary;

        public Employee(int salary_)
        {
            salary = salary_;
        }

        public override string ToString()
        {
            return $"Salary: {salary}\n================";
        }
    }
}