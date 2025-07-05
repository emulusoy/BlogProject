using System.ComponentModel.DataAnnotations;

namespace BlogProject.PresentationLayer.Models
{
    public class AdminProfileUpdateViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmNewPassword { get; set; }
    }
}
