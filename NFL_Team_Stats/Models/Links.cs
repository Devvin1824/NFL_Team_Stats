using Newtonsoft.Json;

namespace NFL_Team_Stats.Models
{
    public class Links
    {
        [JsonProperty("win-stats")]
        public WinStats winstats { get; set; }
        public Self self { get; set; }
    }
}
