﻿using Delt.Models.AbstractClasses;
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

        [Required(ErrorMessage = "فیلد مدرس اجباری است.")]
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } = null!;
    }
}