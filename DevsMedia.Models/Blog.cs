using System.ComponentModel.DataAnnotations.Schema;

namespace DevsMedia.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string BlogText { get; set; } = null!;
        public DateTime ReleaseTime { get; set; }
        [ForeignKey("Admin")]
        public int CreatorId { get; set; }
        public Admin Admin { get; set; } = null!;
    }
}
