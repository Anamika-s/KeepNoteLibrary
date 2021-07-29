using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepNoteDAOLayer.Models;
namespace KeepNoteDAOLayer
{
    public class KeepNotes
    {  KeepNoteDAOLayer.Models.KeepNoteDbContext db = new KeepNoteDAOLayer.Models.KeepNoteDbContext();

        public KeepNotes()
        {  
            GetAllUsers();
            GetAllCat();
        }
        public List<KeepNoteDAOLayer.Models.User> GetAllUsers()
        {
            KeepNoteDAOLayer.Models.User user1 = new KeepNoteDAOLayer.Models.User()
            {
                 UserName="user1"
            };

            KeepNoteDAOLayer.Models.User user2= new KeepNoteDAOLayer.Models.User()
            {
                UserName = "user2"
            };

 
            db.Users.Add(user1);
            db.Users.Add(user2);
            

            db.SaveChanges();
            return db.Users.ToList();
        }
          public List<KeepNoteDAOLayer.Models.Category> GetAllCat()
        {
            KeepNoteDAOLayer.Models.Category category1 = new KeepNoteDAOLayer.Models.Category()
            {
                CategoryName = "Testing 1",
                Description = "This is a Testing 1 note",
                UserId = 5
            };

            KeepNoteDAOLayer.Models.Category category2 = new KeepNoteDAOLayer.Models.Category()
            {
                CategoryName = "Testing 2",
                Description = "This is a Testing 2 note",
                UserId = 6
            };

            KeepNoteDAOLayer.Models.Category category3 = new KeepNoteDAOLayer.Models.Category()
            {
                CategoryName = "Testing 3",
                Description = "This is a Testing 3 note",
                UserId =7
            };

            KeepNoteDAOLayer.Models.Category category4 = new KeepNoteDAOLayer.Models.Category()
            {
                CategoryName = "Testing 4",
                Description = "This is a Testing 4 note",
                UserId=8
            };


            db.Categories.Add(category1);
            db.Categories.Add(category2);
            db.Categories.Add(category3);
            db.Categories.Add(category4);

            db.SaveChanges();
            return db.Categories.ToList();
        }
        public int InsertNote(KeepNoteDAOLayer.Models.Notes notes)
        {
            db.Notes.Add(notes);
            db.SaveChanges();
            return 1;
        }

        public List<Notes> GetAllNotesForAUser(int userId)
        {
            Category cate =  db.Categories.FirstOrDefault(x => x.UserId == userId);
            var notes = db.Notes.Where(x => x.CategoryId == cate.CategoryId).ToList();
            return notes;
        }
    }
}
