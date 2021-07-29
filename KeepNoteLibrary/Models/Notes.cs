using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepNoteDAOLayer.Models
{
    public class Notes
    {
        public int NotesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean Status { get; set; }
        public int CategoryId { get; set; }

        public Category Category  { get; set; }
    }
}
