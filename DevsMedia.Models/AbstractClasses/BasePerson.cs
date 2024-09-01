namespace DevsMedia.Models.AbstractClasses
{
    public abstract class BasePerson : BaseModel
    {
        public string Name { get; set; } = null!;
        public string? Family { get; set; }
        public string? Bio { get; set; }
        public string? ProfileImage { get; set; }
    }
}
