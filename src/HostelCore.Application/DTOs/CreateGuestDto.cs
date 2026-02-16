namespace HostelCore.Application.DTOs
{
    public class CreateGuestDto
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
    }
}