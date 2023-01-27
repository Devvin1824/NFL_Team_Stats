using NFL_Team_Stats.Models;

namespace NFL_Team_Stats.Models
{
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Embedded
    {
        public List<TeamWinStatsList> teamWinStatsList { get; set; }
        public List<TeamRushingStatsList> teamRushingStatsList { get; set; }
        public List<TeamReceivingStatsList> teamReceivingStatsList { get; set; }
        
    }
}
