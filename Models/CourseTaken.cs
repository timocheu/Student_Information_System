namespace Student_Information_System.Models;

public partial class CourseTaken
{
    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual User? Student { get; set; }
}
