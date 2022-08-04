using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.WorldImmersion
{
    [Authorize(Roles = "Admin, Teacher")]
    public class CreateModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;
        private readonly ILogger<IndexModel> logger;

        public CreateModel(SerpantWebApp.Data.SerpantWebAppContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            this.logger = logger;
        }

        public void PopulateStudentDropDownList(SerpantWebAppContext _context,
           object selected = null)
        {
            var studentQuery = from alpha in _context.Student orderby alpha.ID select alpha;

            ViewData["StudentID"] = new SelectList(studentQuery.AsNoTracking(), "ID", "ID", selected);

        }

        public void PopulateCourseDropDownList(SerpantWebAppContext _context,
           object selected = null)
        {
            var courseQuery = from alpha in _context.Course orderby alpha.CourseID select alpha;

            ViewData["CourseID"] = new SelectList(courseQuery.AsNoTracking(), "CourseID", "CourseID", selected);

        }

        public void PopulateTeacherDropDownList(SerpantWebAppContext _context,
           object selected = null)
        {
            var teacherQuery = from alpha in _context.Teacher orderby alpha.ID select alpha;

            ViewData["TeacherID"] = new SelectList(teacherQuery.AsNoTracking(), "ID", "ID", selected);

        }

        public IActionResult OnGet()
        {
            /* ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID");*/
            PopulateCourseDropDownList(_context);
            PopulateStudentDropDownList(_context);
            PopulateTeacherDropDownList(_context);
            /*ViewData["TeacherID"] = new SelectList(_context.Teacher, "ID", "ID");*/
            return Page();
        }

        /*bool IsExistingStudentID(int studentID, int courseID)
        {
            *//*_context.Attendance.FirstOrDefault(b => b.CourseID == courseID) *//*
            if (_context.Attendance.Distinct(attendance))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }*/


        [BindProperty]
        public Attendance Attendance { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? courseId, int? studentId)
        {
            var emptyAttendance = new Attendance();



            if (!ModelState.IsValid)
            {
                PopulateCourseDropDownList(_context, emptyAttendance.CourseID);
                PopulateStudentDropDownList(_context, emptyAttendance.StudentID);
                PopulateTeacherDropDownList(_context, emptyAttendance.TeacherID);
                return Page();
            }




            _context.Attendance.Add(Attendance);
            var result = await _context.SaveChangesAsync();


            return RedirectToPage("./Index");


        }
    }
}
