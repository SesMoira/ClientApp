using System;
using System.Collections.Generic;

namespace ClientApp.Models
{
    public partial class ClientStartup
    {
        public string Id { get; set; }
        public int? Title { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? CapturedDate { get; set; }
        public string Geolocation { get; set; }
        public string Description { get; set; }
        public string ImageTag { get; set; }
        public byte[] Image { get; set; }
        public string AlbumName { get; set; }
        public string ImageUrl { get; set; }
    }
}
