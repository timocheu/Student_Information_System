﻿using System;
using System.Collections.Generic;

namespace Student_Information_System.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseCode { get; set; }

    public string? Description { get; set; }

    public int? Credits { get; set; }

    public int? TeacherId { get; set; }

    public string? Department { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Teacher? Teacher { get; set; }
}
