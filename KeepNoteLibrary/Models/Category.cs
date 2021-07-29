using System;
using System.Collections.Generic;

namespace KeepNoteDAOLayer.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
       // public string UserName { get; set; }
        public string Description { get; set; }
        public ICollection<Notes> Notes { get; set; } = new List<Notes>();

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
