using Delt.Models.AbstractClasses;
using Delt.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delt.Models
{
    public class Seminar : BaseContent
    {
        [Required(ErrorMessage = "سطح سمینار اجباری است.")]
        [DisplayName("سطح سمینار")]
        public SeminarLevel Level { get; set; }

        [Required(ErrorMessage = "قیمت بلیط اجباری است.")]
        [DisplayName("قیمت بلیط")]
        public double Price { get; set; }

        [Required(ErrorMessage = "فیلد مدرس اجباری است.")]
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "نام مدرس اجباری است.")]
        [DisplayName("مدرس")]
        public Teacher Teacher { get; set; } = null!;
    }
}
