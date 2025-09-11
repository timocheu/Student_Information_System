using System;
using System.Collections.Generic;

namespace Student_Information_System.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public int? Grade1 { get; set; }

    public int? Semester { get; set; }

    public string? GradeDate { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
