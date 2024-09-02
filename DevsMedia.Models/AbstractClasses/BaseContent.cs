using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevsMedia.Models.AbstractClasses
{
    public abstract class BaseContent : BaseModel
    {
        [DisplayName("عنوان")]
        [Length(5, 50, ErrorMessage = "عنوان نباید از 5 کاراکتر کمتر و از 50 کاراکتر بیشتر باشد")]
        public string Title { get; set; } = null!;

        [DisplayName("خلاصه")]
        [Length(20, 200, ErrorMessage = "خلاصه نباید از 20 کاراکتر کمتر و از 200 کاراکتر بیشتر باشد")]
        public string ShortDescription { get; set; } = null!;

        [DisplayName("کاور")]
        public string? CoverImage { get; set; }

        [DisplayName("تاریخ انتشار")]
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
