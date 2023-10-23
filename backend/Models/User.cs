namespace backend.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public string? UserBirthday { get; set; }
        public int? UserLocationId { get; set; }
        public string? UserImage { get; set; }
    }
}
