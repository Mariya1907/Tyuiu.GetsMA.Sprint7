using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.Lib
{
    public class BookService
    {
        public List<Book> LoadFromCsv(string path)
        {
            var books = new List<Book>();

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(';');
                books.Add(new Book
                {
                    Author = parts[0],
                    Title = parts[1],
                    Year = int.Parse(parts[2]),
                    Price = decimal.Parse(parts[3]),
                    IsNew = bool.Parse(parts[4])
                });
            }
            return books;
        }

        public void SaveToCsv(string path, List<Book> books)
        {
            var lines = books.Select(b =>
                $"{b.Author};{b.Title};{b.Year};{b.Price};{b.IsNew}");
            File.WriteAllLines(path, lines);
        }

        public decimal GetAveragePrice(List<Book> books)
        {
            return books.Average(b => b.Price);
        }
    }
}

