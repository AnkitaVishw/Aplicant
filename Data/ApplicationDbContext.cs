using Microsoft.EntityFrameworkCore;
using ApplicantRegistrationForm.Models; // Replace with your actual namespace

namespace ApplicantRegistrationForm.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Applicant> Applicants { get; set; }
  }
}
