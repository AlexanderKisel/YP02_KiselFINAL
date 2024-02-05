using System;
using System.Collections.Generic;

namespace YP02_Kisel.Models
{
    public partial class Autorization
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Fio { get; set; }
        public string? Role { get; set; }
    }
}
