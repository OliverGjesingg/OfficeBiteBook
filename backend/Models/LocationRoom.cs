namespace backend.Models
{
    public class LocationRoom
    {
        public int RoomId { get; set; }
        public int LocationId { get; set; }
        public string? RoomName { get; set; }
        public bool Default { get; set; }
    }
}