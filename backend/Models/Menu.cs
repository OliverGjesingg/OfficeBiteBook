namespace backend.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int MenuTypeId { get; set; }
        public int RoomId { get; set; }
        public bool MenuPublished { get; set; }
        public string? MenuTitle { get; set; }
        public string? MenuStartDate { get; set; }
        public string? MenuEndDate { get; set; }
    }
}
