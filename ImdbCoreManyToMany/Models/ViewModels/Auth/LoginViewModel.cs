using System.ComponentModel.DataAnnotations;

namespace ImdbCoreManyToMany.Models.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(15)]
        public string Password { get; set; }
    }
}
