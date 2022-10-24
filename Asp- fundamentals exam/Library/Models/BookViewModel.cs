using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookViewModel 
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Rating { get; set; }

        public string Category { get; set; }
    }
}
