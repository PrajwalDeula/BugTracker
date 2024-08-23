using BugTracker.DAO;
using Microsoft.AspNetCore.Mvc;
using BugTracker.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.Razor.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace BugTracker.Controllers
{
	public class LibraryController : Controller
	{
		ApplicationDbContext _context;
		public LibraryController(ApplicationDbContext context)
		{
			_context = context;
		}
		public JsonResult Create(string studentname, string studentcode, int id)
		{
			if (studentname == null)
			{
				return Json(new
				{
					Success = false,
					Message = "Enter the student name"

				});
			}
			else if (studentcode == null)
			{
				return Json(new
				{
					Success = false,
					Message = "Enter the student code"
				});
			}

			else {
				if (id == 0)
				{
					Library oldCode = _context
						.Library
						.Where(x => x.StudentCode == studentcode)
						.FirstOrDefault();
					if(oldCode == null) { 
					Library u = new Library()
					{
						studentname = studentname,
						studentcode = studentcode,

					}
					

					}
				_context.Library.Add();
					_context.SaveChanges();
				}
			}

			List<LibraryVM> ug = _context
			.Library
			.Where(x => (string.IsNullOrEmpty(studentname) && x.StudentName == studentname)
			|| (string.IsNullOrEmpty(studentcode) && x.StudentCode == studentcode)
			|| (x.StudentID == studentid))
			.Select(s => new LibraryVM
			{
				StudentName = s.StudentName,
				StudentCode = s.StudentCode,
				StudentID = s.StudentID

			})
			.ToList();

			return Json(new
			{
				Success = true,
				Messsage = "Libray Added Succesfully"
			});
				
		}
		public IActionResult Library()
		{
			return View();
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
