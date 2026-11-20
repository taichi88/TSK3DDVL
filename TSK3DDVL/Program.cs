using System.Globalization;
using TSK3DDVL;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            IArrayHelper arrayHelper = new ArrayHelper();


            int[] numbers = { 4, 15, 1, 9, 10 };
            numbers = arrayHelper.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers: {numbers[i]}");
            }


            string[] names = { "Alice", "Bob", "Charlie", "Diana", "Eve" };       

            names = arrayHelper.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names: {names[i]}");
            }
         object[] books = new Book[]
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 10.99),
                new Book("To Kill a Mockingbird", "Harper Lee", 1960, 12.99),
                new Book("1984", "George Orwell", 1949, 9.99),
                new Book("Pride and Prejudice", "Jane Austen", 1813, 8.99),
                new Book("The Catcher in the Rye", "J.D. Salinger", 1951, 11.99),
                new Book("The Hobbit", "J.R.R. Tolkien", 1937, 14.99),
                new Book("Moby-Dick", "Herman Melville", 1851, 13.99),
                new Book("War and Peace", "Leo Tolstoy", 1869, 15.99),
                new Book("The Odyssey", "Homer", -800, 7.99),
                new Book("Crime and Punishment", "Fyodor Dostoevsky", 1866, 12.49)
            };

            books = arrayHelper.Sort(books);

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }

           
        }
    }
    //public abstract class Sortable
    //{
    //    public abstract bool SortByPrice(object obj);
    //}


    //class Book : Sortable
    //{
    //    public Book(string title, string author, int year, double price)
    //    {
    //        Title = title;
    //        Author = author;
    //        Year = year;
    //        Price = price;
    //    }

    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public int Year { get; set; }
    //    public double Price { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Title: {Title}, Author: {Author}, Year: {Year}, Price: {Price:0.00}";
    //    }

    //    public override bool SortByPrice(object obj)
    //    {
    //        if (obj is Book other)
    //        {
    //            return this.Price > other.Price;
    //        }

    //        return false;
    //    }
    //}
    
    
    

    //static class ArrayHelper
    //{
    //    //We need to implement the Sort method for the array of unknown type.
    //    //Sorting logic will be the same we just need to solve
    //    //the problem of comparing two objects of unknown type.
    //    public static void Sort(object[] array)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                // We need to compare two objects of unknown type.
    //                if (array[j].SortByPrice(array[j + 1]))
    //                {
    //                    var temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
        

    //    public static void Sort(string[] array)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (array[j].Length > array[j + 1].Length)
    //                {
    //                    var temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }

    //    public static void Sort(int[] array)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (array[j] > array[j + 1])
    //                {
    //                    var temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    }
//}