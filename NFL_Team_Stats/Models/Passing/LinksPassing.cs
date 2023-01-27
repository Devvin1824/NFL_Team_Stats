using Newtonsoft.Json;
using NFL_Team_Stats.Controllers;
using NFL_Team_Stats.Models;

namespace NFL_Team_Stats.Models
{
    public class LinksPassing
    {
        [JsonProperty("passing-stats")]
        public PassingStats passingstats { get; set; }
        public Self self { get; set; }
    }
}
