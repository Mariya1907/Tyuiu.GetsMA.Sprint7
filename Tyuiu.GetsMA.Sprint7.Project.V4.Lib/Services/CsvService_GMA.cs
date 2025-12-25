using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Models;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Services
{
    public class CsvService_GMA  
    {
        public List<Book_GMA> LoadBooksFromCsv(string filePath)
        {
            List<Book_GMA> books = new List<Book_GMA>();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Book_GMA book = Book_GMA.Parse(line);
                        books.Add(book);
                    }
                }
            }
            return books;
        }

        public void SaveBooksToCsv(List<Book_GMA> books, string filePath)
        {
            List<string> lines = new List<string>();
            foreach (Book_GMA book in books)
            {
                lines.Add(book.ToString());
            }
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }
    }
}
