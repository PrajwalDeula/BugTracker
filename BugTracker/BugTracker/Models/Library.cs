using System.ComponentModel.DataAnnotations;
using System;

namespace BugTracker.Models
{
	public class Library
	{
		[Key]
		public int StudentID { get; set; }
		public string StudentName { get; set;}
		public string StudentCode { get; set; }
	}
}
