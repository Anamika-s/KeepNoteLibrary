using System;
using System.Collections.Generic;

namespace KeepNoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            KeepNoteDAOLayer.KeepNotes keepNotes = new KeepNoteDAOLayer.KeepNotes();
         
           KeepNoteDAOLayer.Models.Notes notes = new KeepNoteDAOLayer.Models.Notes();
            Console.WriteLine("Enter Title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Des");
            string desc = Console.ReadLine();
            Console.WriteLine("Enter Status");
            Boolean status = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("ENter Catae");
            int categoryId = int.Parse(Console.ReadLine());
            notes = new KeepNoteDAOLayer.Models.Notes()
            { Title = title, Description = desc, Status = status, CategoryId = categoryId };
            int flag = keepNotes.InsertNote(notes);
            if(flag==1)
                Console.WriteLine("One Note is inserted");

            Console.WriteLine("Enter UserID for which ypu want to see all notes");
            int userId = int.Parse(Console.ReadLine());
            List<KeepNoteDAOLayer.Models.Notes> notesList = keepNotes.GetAllNotesForAUser(userId);
            if(notesList.Count!=0)
            {
                foreach()
            }
        }
    }
}