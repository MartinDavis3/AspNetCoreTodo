using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }     //GUID is just an automatically generated string as an identifier
        public bool IsDone { get; set; }
        [Required]       //Specifies that next item (Title) is required (can't be missing)
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }   //? means that DateTimeOffset can explicitly be set to NULL
    }
}

