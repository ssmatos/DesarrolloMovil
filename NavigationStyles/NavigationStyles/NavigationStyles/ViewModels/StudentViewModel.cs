using NavigationStyles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationStyles.ViewModels
{
	public class StudentViewModel
	{
		Student studentSelected;
		public Student StudentSelected { get
			{
				return studentSelected;
			}
			set
			{
				studentSelected = value;
				//DisplayElementSelected();
			}
		}
		public List<Student> Students { get; set; } = new List<Student>();
		public StudentViewModel()
		{
			Students.Add(new Student() { Name = "Sebastian", Id = "1087765", Image = "user" });
			Students.Add(new Student() { Name = "Diego", Id = "1087765", Image = "user" });
			Students.Add(new Student() { Name = "Axel", Id = "1087765", Image = "user" });
		}
	}
}
