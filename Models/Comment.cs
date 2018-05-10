using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtomJournal.Models
{
    public class Comment : BaseEntity
    {
        public int CommentId {get;set;}
        public string CommentBody {get;set;}
        public User user {get;set;} 
        public Journal journal {get;set;}
        public int UserId {get;set;}
        public int JournalId {get;set;}
    }
}