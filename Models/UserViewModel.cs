using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace AtomJournal.Models
{
    public abstract class BaseEntity
    {
        // EMPTY!!!
    }
    public class RegUser : BaseEntity
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MinLength(2, ErrorMessage="Full Name must be at least 2 characters!")]
        public string FullNamr { get;set; }

        [Required]
        [EmailAddress]
        public string Email { get;set; }

        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get;set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get;set; }
    }
    public class LoginUser : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get;set; }

        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get;set; }
    }

    public class CreateJournal : BaseEntity
    {
        [Required]
        [MinLength(2, ErrorMessage="Mood must be filled out!")]
        public string JournalMood {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Journal must be filled out!")]
        public string JournalBody {get;set;}


    }
}
// MIGRATION NOTES: 
// dotnet ef migrations add FirstMigration
// dotnet ef database update