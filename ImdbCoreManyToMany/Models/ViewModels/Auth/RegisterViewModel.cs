using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ImdbCoreManyToMany.Models.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(15)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }

        [Required]
        public IFormFile AuthorPicture { get; set; }
    }
}
