using Delt.Models.AbstractClasses;
using System.ComponentModel;

namespace Delt.Models
{
    public class Teacher : BasePerson
    {
        [DisplayName("میزان تجربه")]
        public int Experience { get; set; }
    }
}
