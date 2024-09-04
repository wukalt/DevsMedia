using DevsMedia.Models.AbstractClasses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevsMedia.Models
{
    public class Blog : BaseContent
    {
        [Required(ErrorMessage = "متن کامل اجباری است")]
        [DisplayName("متن کامل")]
        public string BlogText { get; set; } = null!;
    }
}
