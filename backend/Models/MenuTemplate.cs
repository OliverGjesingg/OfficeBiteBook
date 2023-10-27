namespace backend.Models
{
    public class MenuTemplate
    {
        public int TemplateId { get; set; }
        public int MenuTypeId { get; set; }
        public int LocationId { get; set; }
        public string? Title { get; set; }
    }
}
