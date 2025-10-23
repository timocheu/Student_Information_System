using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Models;

public class Logs
{
    public int id { get; set; }
    public int? UserId { get; set; } 
    public string? Timestamp { get; set; }
    public string? Level { get; set; }
    public string? Action { get; set; }
    public string? Message { get; set; }
    public string? Exception { get; set; }
}
