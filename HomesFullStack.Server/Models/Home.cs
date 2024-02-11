using System.Globalization;

namespace HomesFullStack.Server.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string  Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;     
        public string? City { get; set; }
        public string? State { get; set; }
        public bool Wifi { get; set; }
        public bool Laundry { get; set; }

    }
}
