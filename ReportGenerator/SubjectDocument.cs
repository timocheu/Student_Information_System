using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using Student_Information_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Student_Information_System.ReportGenerator;
public class SubjectDocument: IDocument
{
    private SisContext context { get; }
    public SubjectDocument(SisContext context)
    {
        this.context = context;
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
                    .Text($"Active Subjects Report")
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
        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.ConstantColumn(25);
                columns.RelativeColumn(2);
                columns.RelativeColumn();
                columns.RelativeColumn(10);
                columns.RelativeColumn();
                columns.RelativeColumn();
                columns.RelativeColumn();
            });

            table.Header(header =>
            {
                header.Cell().Element(CellStyle).Text("#");
                header.Cell().Element(CellStyle).Text("Course Name");
                header.Cell().Element(CellStyle).Text("Code");
                header.Cell().Element(CellStyle).Text("Description");
                header.Cell().Element(CellStyle).Text("Credits");
                header.Cell().Element(CellStyle).Text("Teacher ID");
                header.Cell().Element(CellStyle).Text("Department");
                
                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.SemiBold().FontSize(10)).Border(1).Padding(5).BorderColor(Colors.Black);
                }
            });

            foreach (var course in context.Courses.Where(u => u.Status == 1))
            {
                table.Cell().Element(CellStyle).Text(course.CourseId.ToString());
                table.Cell().Element(CellStyle).Text(course.CourseName);
                table.Cell().Element(CellStyle).Text(course.CourseCode);
                table.Cell().Element(CellStyle).Text(course.Description);
                table.Cell().Element(CellStyle).Text(course.Credits.ToString());
                table.Cell().Element(CellStyle).Text(course.TeacherId.ToString());
                table.Cell().Element(CellStyle).Text(course.Department);
                
                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.FontSize(9)).Border(1).Padding(3).BorderColor(Colors.Grey.Lighten3).PaddingVertical(3);
                }
            }
        });
    }
}
