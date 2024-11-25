using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicantRegistrationForm.Models // Ensure this matches your project's namespace
{
  public class Applicant
  {
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? FatherName { get; set; }

    [Required]
    public string? Address { get; set; }

    [Required]
    public string? Gender { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    public string? Qualification { get; set; } // Nullable to address warnings

    public string? State { get; set; } // Nullable to address warnings

    public string? District { get; set; } // Nullable to address warnings

    public string? Hobbies { get; set; } // Nullable to address warnings

    public string? PhotoPath { get; set; } // Nullable to address warnings

    public string? SignaturePath { get; set; } // Nullable to address warnings
  }
}
