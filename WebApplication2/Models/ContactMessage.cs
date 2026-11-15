using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "יש להזין שם מלא")]
        [StringLength(50)]
        [Display(Name = "שם מלא")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "יש להזין כתובת אימייל")]
        [EmailAddress(ErrorMessage = "כתובת אימייל לא תקינה")]
        [Display(Name = "אימייל")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "יש להזין נושא")]
        [StringLength(100)]
        [Display(Name = "נושא הפנייה")]
        public string Subject { get; set; } = "";

        [Required(ErrorMessage = "יש להזין תוכן הודעה")]
        [StringLength(500)]
        [Display(Name = "תוכן ההודעה")]
        public string Message { get; set; } = "";

        [Display(Name = "תאריך הפנייה")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}