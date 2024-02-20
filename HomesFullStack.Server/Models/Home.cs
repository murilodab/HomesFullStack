using System.Globalization;

namespace HomesFullStack.Server.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string?  Name { get; set; }
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ImageBase64 { get; set; }
        public bool Wifi { get; set; }
        public bool Laundry { get; set; }

    }
}
