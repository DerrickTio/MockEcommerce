using System.ComponentModel.DataAnnotations;

namespace MockEcommerce.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}