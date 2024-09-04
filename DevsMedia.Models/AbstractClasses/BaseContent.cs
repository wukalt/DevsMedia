using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevsMedia.Models.AbstractClasses
{
    public abstract class BaseContent : BaseModel
    {
        [Required(ErrorMessage = "عنوان اجباری است")]
        [DisplayName("عنوان")]
        [Length(5, 80, ErrorMessage = "عنوان نباید از 5 کاراکتر کمتر و از 80 کاراکتر بیشتر باشد")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "توضیح کوتاه اجباری است")]
        [DisplayName("خلاصه")]
        [Length(20, 150, ErrorMessage = "خلاصه نباید از 20 کاراکتر کمتر و از 150 کاراکتر بیشتر باشد")]
        public string ShortDescription { get; set; } = null!;

        [DisplayName("کاور")]
        public string? CoverImage { get; set; }

        [DisplayName("تاریخ انتشار")]
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
