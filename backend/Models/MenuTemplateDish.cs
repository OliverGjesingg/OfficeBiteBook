namespace backend.Models
{
    public class MenuTemplateDish
    {
        public int TemplateId { get; set; }
        public string? TemplateTitle { get; set; }
        public int DishId { get; set; }
        public string? DishTitle { get; set; }
    }
}
