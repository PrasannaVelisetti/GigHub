using System;
using System.Collections;
namespace GigHubCore.Models
{
    public class Gig
    {
        public int Id { get; set; }
        public ApplicationUser Artist { get; set; }
        public Genre Genre { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
    }
}
