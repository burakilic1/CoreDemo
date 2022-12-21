using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel 
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad Soyada Giriniz")]
        public string NameSurname { get; set; }

        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Display(Name ="Şifre Tekrarı")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name ="Mail Giriniz")]
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }

        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınzıı Giriniz")]
        public string UserName { get; set; }

        [Display(Name ="Image URL")]
        [Required(ErrorMessage = "Lütfen Image Url Giriniz")]
        public string ImageUrl { get; set; }
    }
}
