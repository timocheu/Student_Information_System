using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using Student_Information_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Student_Information_System.ReportGenerator;
public class StudentDocument : IDocument
{
    private SisContext context { get; }
    public StudentDocument(SisContext context)
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
                    .Text($"Student Report #")
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
                columns.RelativeColumn();
                columns.RelativeColumn(2);
                columns.RelativeColumn();
                columns.RelativeColumn(2);
                columns.RelativeColumn();
            });

            table.Header(header =>
            {
                header.Cell().Element(CellStyle).Text("#");
                header.Cell().Element(CellStyle).Text("Name");
                header.Cell().Element(CellStyle).Text("Gender");
                header.Cell().Element(CellStyle).Text("Date Of Birth");
                header.Cell().Element(CellStyle).Text("Email");
                header.Cell().Element(CellStyle).Text("Phone");
                header.Cell().Element(CellStyle).Text("Address");
                header.Cell().Element(CellStyle).Text("Program");
                
                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.SemiBold().FontSize(10)).Border(1).Padding(5).BorderColor(Colors.Black);
                }
            });

            foreach (var user in context.Users.Include(u => u.Student).Where(u => u.Student!.Status == 1))
            {
                table.Cell().Element(CellStyle).Text(user.UserId.ToString());
                table.Cell().Element(CellStyle).Text($"{user.LastName}, {user.FirstName}");
                table.Cell().Element(CellStyle).Text(user.Gender);
                table.Cell().Element(CellStyle).Text(user.DateOfBirth);
                table.Cell().Element(CellStyle).Text(user.Email);
                table.Cell().Element(CellStyle).Text(user.Phone);
                table.Cell().Element(CellStyle).Text(user.Address);
                table.Cell().Element(CellStyle).Text(user.Student?.Program);
                
                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.FontSize(9)).Border(1).Padding(3).BorderColor(Colors.Grey.Lighten3).PaddingVertical(3);
                }
            }
        });
    }
}

