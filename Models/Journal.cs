using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AtomJournal.Models
{
    public class Journal : BaseEntity
    {
        // These must match the columns in your database's table!
        [Key]
        public int JournalId {get; set;}
        public int UserId {get;set;}
        public string JournalMood {get;set;}
        public string JournalBody {get;set;}
        public User user {get;set;} 
        public List<Comment> Comments {get;set;}
        public Journal()
        {
            Comments = new List<Comment>();
        }
    }
}