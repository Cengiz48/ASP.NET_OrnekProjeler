using System.ComponentModel.DataAnnotations;

namespace KursBasvuruOrnek.Models
{

    public class Candidate
    {
        [EmailAddress]
        [Required(ErrorMessage ="Email is Required")]
        public string? Email { get; set; } =string.Empty;
        [Required(ErrorMessage ="FirstName is Required")]
        public string? FirstName { get; set; } =string.Empty;
        [Required(ErrorMessage ="LastName is Required")]
        public string? LastName { get; set; } =string.Empty;

        [Required(ErrorMessage ="Age is Required")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Course is Required")]
        public string? SelectedCourse { get; set; } = string.Empty;

        public DateTime ApplyAt { get; set; }


        public Candidate()
        {
            ApplyAt=DateTime.Now;

        }
    }



}