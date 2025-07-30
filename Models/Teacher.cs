using System;
using System.Collections.Generic;

namespace Student_Information_System.Models;

public partial class Teacher
{
    public int UserId { get; set; }

    public string? HireDate { get; set; }

    public string? Department { get; set; }

    public string? Specialization { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual User User { get; set; } = null!;
}
