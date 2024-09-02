using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevsMedia.Models.AbstractClasses
{
    public abstract class BasePerson : BaseModel
    {
        [DisplayName("نام")]
        [MaxLength(25, ErrorMessage = "طول نام باید کمتر از 25 کاراکتر باشد")]
        public string Name { get; set; } = null!;

        [DisplayName("نام خانوادگی")]
        [MaxLength(25, ErrorMessage = "طول نام خانوادگی باید کمتر از 25 کاراکتر باشد")]
        public string? Family { get; set; }

        [DisplayName("بیوگرافی")]
        [MaxLength(100, ErrorMessage = "طول بیوگرافی باید کمتر از 100 کاراکتر باشد")]
        public string? Bio { get; set; }

        [DisplayName("عکس پروفایل")]
        public string? ProfileImage { get; set; }
    }
}
