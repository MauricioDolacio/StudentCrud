using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentCrud.Models;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter the name")]
    [StringLength(80, ErrorMessage = "The name must contain up to 80 characters")]
    [MinLength(5, ErrorMessage = "The name must contain at least 5 characters")]
    [DisplayName("Full Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter the email")]
    [EmailAddress(ErrorMessage = "Invalid email")]
    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();
}