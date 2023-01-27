namespace NFL_Team_Stats.Models
{
    public class TeamWinStatsList
    {
        public string name { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public double winRatePercentage { get; set; }
        public Links _links { get; set; }
    }
}
