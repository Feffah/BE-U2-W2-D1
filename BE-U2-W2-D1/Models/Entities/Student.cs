namespace BE_U2_W2_D1.Models.Entities;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(50)]
    public string Cognome { get; set; }
    [Required]
    public DateTime DataNascita { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}

