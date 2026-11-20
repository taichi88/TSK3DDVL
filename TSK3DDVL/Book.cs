using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TSK3DDVL;
class Book : ArrayHelper
{
    public Book(string title, string author, int year, double price)
    {
        Title = title;
        Author = author;
        Year = year;
        Price = price;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }



    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Year: {Year}, Price: {Price:0.00}";
    }

    public bool SortByPrice(Book other)
    {
        return this.Price > other.Price;
    }
}


    //public bool SortByPrice(object[] obj)
    //{
    //    if (obj is Book other)
    //    {
    //        return this.Price > other.Price;
    //    }

    //    return false;
    //    throw new NotImplementedException();

    //}

    
