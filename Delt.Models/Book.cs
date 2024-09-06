using Delt.Models.AbstractClasses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Delt.Models
{
    public class Book : BaseContent
    {
        [Required(ErrorMessage = "نام نویسنده اجباری است.")]
        [MaxLength(100, ErrorMessage = "نام نویسنده نباید از 100 کاراکتر بیشتر باشد.")]
        [DisplayName("نویسنده")]
        public string Author { get; set; } = null!;

        [Required(ErrorMessage = "نام منتشر اجباری است.")]
        [MaxLength(100, ErrorMessage = "نام منتشر نباید از 100 کاراکتر بیشتر باشد.")]
        [DisplayName("ناشر")]
        public string Publisher { get; set; } = null!;

        [DisplayName("لینک دانلود")]
        [Required(ErrorMessage = "لینک دانلود الزامی است.")]
        public string DownloadLink { get; set; } = null!;
    }
}
