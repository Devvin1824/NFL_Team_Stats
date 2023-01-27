using Microsoft.AspNetCore.Mvc.Rendering;

namespace NFL_Team_Stats.Models
{
    public class Root
    {
        public Embedded _embedded { get; set; }
        public Links _links { get; set; }

       
    }
}
