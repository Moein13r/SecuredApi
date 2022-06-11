using System.ComponentModel.DataAnnotations;

namespace TestProject.Dtos
{
    public class CommandUpdateDtos
    {
        [Required]
        public string? HowTo { get; set; }
        [Required]
        [MaxLength(5)]
        public string? Platforms { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}