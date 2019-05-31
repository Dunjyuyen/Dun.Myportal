using System.ComponentModel.DataAnnotations;

namespace Dun.Myportal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}