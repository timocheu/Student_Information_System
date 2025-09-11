using System;
using System.Collections.Generic;

namespace Student_Information_System.Models;

public partial class Student
{
    public int UserId { get; set; }

    public string? EnrollmentDate { get; set; }

    public string? Program { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual User User { get; set; } = null!;
}
