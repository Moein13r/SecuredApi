using System;
using System.Collections.Generic;

namespace TestProject.Models
{
    public partial class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; } = null!;
        public string Platforms { get; set; } = null!;
        public string CommandLine { get; set; } = null!;
    }
}
