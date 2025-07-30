using System;
using System.Collections.Generic;

namespace Student_Information_System.Models;

public partial class UserLogin
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public byte[] PasswordHash { get; set; } = null!;

    public byte[] PasswordSalt { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
