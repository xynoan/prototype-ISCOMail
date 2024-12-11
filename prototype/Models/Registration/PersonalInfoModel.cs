using System.ComponentModel.DataAnnotations;

namespace prototype.Models.Registration
{
    public class PersonalInfoModel
    {
        // Full Name Fields
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string Suffix { get; set; }

        // Background Information
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Birth Place is required.")]
        public string BirthPlace { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Religion is required.")]
        public string Religion { get; set; }

        [Required(ErrorMessage = "Citizenship is required.")]
        public string Citizenship { get; set; }

        [Required(ErrorMessage = "Civil Status is required.")]
        public string CivilStatus { get; set; }

        // Address Fields
        [Required(ErrorMessage = "House/Street is required.")]
        public string HouseStreet { get; set; }

        [Required(ErrorMessage = "Barangay is required.")]
        public string Barangay { get; set; }

        [Required(ErrorMessage = "Municipality is required.")]
        public string Municipality { get; set; }

        [Required(ErrorMessage = "District is required.")]
        public string District { get; set; }

        [Required(ErrorMessage = "Zip Code is required.")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
    }
}
