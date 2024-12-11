using System.ComponentModel.DataAnnotations;

namespace prototype.Models.Registration
{
    public class StepOneModel
    {
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "LRN is required.")]
        public int LRN { get; set; }

        [Required(ErrorMessage = "Student Number is required.")]
        public string StudentNumber { get; set; }

        [Required(ErrorMessage = "Applying As is required.")]
        public string ApplyingAs { get; set; }

        [Required(ErrorMessage = "Track is required.")]
        public string Track { get; set; }

        [Required(ErrorMessage = "Strand is required.")]
        public string Strand { get; set; }

        public string FirstChoice { get; set; }
        public string SecondChoice { get; set; }
        public string ThirdChoice { get; set; }
        public string CurrentlyEnrolled { get; set; }
        public string SchoolName { get; set; }
        public string FirstCampusChoice { get; set; }
        public string SecondCampusChoice { get; set; }
        public string ThirdCampusChoice { get; set; }
    }
}
