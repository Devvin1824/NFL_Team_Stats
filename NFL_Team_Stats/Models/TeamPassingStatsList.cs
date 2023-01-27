using NFL_Team_Stats.Controllers;
using NFL_Team_Stats.Models;

namespace NFL_Team_Stats.Models
{
    public class TeamPassingStatsList
    {
        public string name { get; set; }
        public int passYards { get; set; }
        public int completions { get; set; }
        public int touchdowns { get; set; }
        public LinksPassing _linkspassing { get; set; }


    }
}
