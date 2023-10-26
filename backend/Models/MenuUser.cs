namespace backend.Models
{
    public class MenuUser
    {
        public int MenuId { get; set; }
        public int UserId { get; set; }
        public string? MenuTitle { get; set; }
        public string? UserName { get; set; }
    }
}
