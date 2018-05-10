using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtomJournal.Models
{
    public class User : BaseEntity
    {
        private List<Journal> _journals;
        // These must match your columns in your table database!
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Journal> Journals { get => _journals; set => _journals = value; }
        public User()
        {
            Journals = new List<Journal>();
        }
    }
}