namespace DevsMedia.Models.AbstractClasses
{
    public abstract class BaseContent : BaseModel
    {
        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string? CoverImage { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
