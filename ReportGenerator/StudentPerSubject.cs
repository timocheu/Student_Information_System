using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using Student_Information_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Student_Information_System.ReportGenerator;
public class StudentPerSubjectDocument : IDocument
{
    private IGrouping<int?, CourseTaken>? courseGroup { get; }
    public StudentPerSubjectDocument(IGrouping<int?, CourseTaken>? courseGroup)
    {
        this.courseGroup = courseGroup;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public DocumentSettings GetSettings() => DocumentSettings.Default;

    public string ImagePath() => @"../../../Images/images.png";

    public void Compose(IDocumentContainer container)
    {
        container
            .Page(page =>
            {
                page.Size(PageSizes.A4.Landscape());
                page.Margin(20);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeData);
            });
    }

    private void ComposeHeader(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Column(column =>
            {
                column.Item()
                    .Text($"Student Per Subject")
                    .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                column.Item().Text(text =>
                {
                    text.Span("Issue date: ").SemiBold();
                    text.Span($"{DateTime.Now.ToString()}");
                });
            });

            row.ConstantItem(100).AlignCenter().Height(50).Width(50).Image(ImagePath()).FitWidth().FitHeight();
        });
    }

    private void ComposeData(IContainer container)
    {
        var course = courseGroup.First().Course;
        string subjectName = course.CourseName;
        string subjectCode = course.CourseCode;
        string teacherName = $"{course.Teacher.User.LastName}, {course.Teacher.User.FirstName}";

        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.RelativeColumn();
                columns.RelativeColumn(2);
                columns.RelativeColumn();
                columns.RelativeColumn();
                columns.RelativeColumn(2);
            });


            table.Header(header =>
            {
                header.Cell().ColumnSpan(5).Element(CellStyle).Text($"{subjectName}({subjectCode}) by Instructor {teacherName}").AlignCenter();

                header.Cell().Element(CellStyle).Text("#");
                header.Cell().Element(CellStyle).Text("Name");
                header.Cell().Element(CellStyle).Text("Gender");
                header.Cell().Element(CellStyle).Text("Enrollment_Date");
                header.Cell().Element(CellStyle).Text("Program");

                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.SemiBold().FontSize(10)).Border(1).Padding(5).BorderColor(Colors.Black);
                }
            });

            int index = 1;
            foreach (var ct in courseGroup)
            {
                var user = ct.Student;

                table.Cell().Element(CellStyle).Text(index.ToString());
                table.Cell().Element(CellStyle).Text($"{user.LastName}, {user.FirstName}");
                table.Cell().Element(CellStyle).Text(user.Gender);
                table.Cell().Element(CellStyle).Text(user.Student?.EnrollmentDate);
                table.Cell().Element(CellStyle).Text(user.Student?.Program);

                index++;

                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.FontSize(9)).Border(1).Padding(3).BorderColor(Colors.Grey.Lighten3).PaddingVertical(3);
                }
            }
        });
    }
}
