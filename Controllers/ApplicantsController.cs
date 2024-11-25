using Microsoft.AspNetCore.Mvc;
using ApplicantRegistrationForm.Data; // Make sure this is correct
using ApplicantRegistrationForm.Models;

public class ApplicantsController : Controller
{
  private readonly ApplicationDbContext _context;

  public ApplicantsController(ApplicationDbContext context)
  {
    _context = context;
  }

  // GET: Applicants/Create
  public IActionResult Create()
  {
    return View();
  }

  // POST: Applicants/Create
  [HttpPost]
  [ValidateAntiForgeryToken]
  public async Task<IActionResult> Create([Bind("Name, FatherName, Address, DateOfBirth, Gender, Qualification, State, District, Hobbies, Photo, Signature")] Applicant applicant)
  {
    if (ModelState.IsValid)
    {
      _context.Add(applicant);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index)); // Or wherever you want to redirect after saving
    }
    return View(applicant);
  }
}
