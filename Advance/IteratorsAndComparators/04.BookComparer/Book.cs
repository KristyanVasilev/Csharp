using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

 namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public string[] Authors { get; set; }

        public int CompareTo(Book other)
        {
            int result = Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = Title.CompareTo(other.Title);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
    //public class Book : IComparable<Book>
    //{
    //    public Book(string title, int year, params string[] authors)
    //    {
    //        this.Title = title;
    //        this.Year = year;
    //        this.Authors = authors.ToList();
    //    }

    //    public string Title { get; set; }

    //    public int Year { get; set; }

    //    public List<string> Authors { get; set; }

    //    public int CompareTo(Book other)
    //    {
    //        // this == other   0
    //        // this > other    1
    //        // this < other    -1
    //        if (Year > other.Year)
    //        {
    //            return 1;
    //        }
    //        else if (Year < other.Year)
    //        {
    //            return -1;
    //        }
    //        else // =
    //        {
    //            return Title.CompareTo(other.Title);
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        return $"{string.Join(" & ", Authors)} - {Title} ({Year})";
    //    }
    //}
}
