using System.Collections.Generic;
using GigHubCore.Models;

namespace GigHubCore.ViewModels
{
    public class GigViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
