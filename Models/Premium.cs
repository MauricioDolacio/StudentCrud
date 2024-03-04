using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentCrud.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter the Premium Title")]
    [StringLength(80, ErrorMessage = "The title must contain up to 80 characters")]
    [MinLength(5, ErrorMessage = "The title must contain at least 5 characters")]
    [DisplayName("Title")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [DisplayName("Start")]
    public DateTime StartDate { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Finish")]
    public DateTime EndDate { get; set; }

    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Invalid Student")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }
}