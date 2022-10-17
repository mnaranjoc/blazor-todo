using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data
{
    public class TodoList
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }
    }
}
