using System;

namespace SafariApp.Models
{
    public class SeenAnimals
    {
        public int ID { get; set; }
        public string Species { get; set; }
        public int TimesSeen { get; set; }
        public string LocationLastSeen { get; set; }
    }
}