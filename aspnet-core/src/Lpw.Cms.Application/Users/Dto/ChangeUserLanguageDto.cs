using System.ComponentModel.DataAnnotations;

namespace Lpw.Cms.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}