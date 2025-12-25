using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Models
{
    public class Book_GMA
    {
        public string Author { get; set; } = "";
        public string Title { get; set; } = "";
        public int Year { get; set; } = 0;
        public decimal Price { get; set; } = 0;
        public bool IsNewEdition { get; set; } = false;
        public string Annotation { get; set; } = "";

        public override string ToString()
        {
            return $"{Author};{Title};{Year};{Price};{IsNewEdition};{Annotation}";
        }

        public static Book_GMA Parse(string csvLine)
        {
            string[] parts = csvLine.Split(';');
            Book_GMA book = new Book_GMA
            {
                Author = parts.Length > 0 ? parts[0].Trim() : "",
                Title = parts.Length > 1 ? parts[1].Trim() : "",
                Year = parts.Length > 2 && int.TryParse(parts[2].Trim(), out int year) ? year : 0,
                Price = parts.Length > 3 && decimal.TryParse(parts[3].Trim(), System.Globalization.CultureInfo.InvariantCulture, out decimal price) ? price : 0,
                IsNewEdition = parts.Length > 4 && bool.TryParse(parts[4].Trim(), out bool isNew) ? isNew : false,
                Annotation = parts.Length > 5 ? parts[5].Trim() : ""
            };
            return book;
        }
    }
}


