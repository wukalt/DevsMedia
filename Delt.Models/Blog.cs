using Delt.Models.AbstractClasses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Delt.Models
{
    public class Blog : BaseContent
    {
        [Required(ErrorMessage = "متن کامل اجباری است")]
        [DisplayName("متن کامل")]
        public string BlogText { get; set; } = null!;
    }
}
