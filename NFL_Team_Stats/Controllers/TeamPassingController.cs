using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NFL_Team_Stats.Models;
using RestSharp;
using System.Reflection;

namespace NFL_Team_Stats.Controllers
{
    public partial class TeamPassingController : Controller
    {

        public readonly EmbeddedPassing _embedded;
        public TeamPassingController()
        {
            _embedded = new EmbeddedPassing();
        }

        
        [HttpPost]
        public IActionResult TeamStatsPassingWindow(string team, string year)
        {
            var nflURL = "https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/" + year;
            //var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/2016");
            var client = new RestClient(nflURL);
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<RootPassing>(response.Content);
            int index = 15;
            for (int i = 0; i < 32; i++)
            {
                if (root._embedded.teamPassingStatsList[i].name.Contains(team))
                {
                    index = i;
                    break;
                }
            }
            ViewData["index"] = index;
            ViewData["tName"] = team;
            ViewData["year"] = year;
            return View(root);
        }
        public IActionResult BrownsPassing()
        {
            var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/2016");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<RootPassing>(response.Content);
            return View(root);
        }
        public IActionResult NinersPassing()
        {
            var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/2016");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<RootPassing>(response.Content);
            return View(root);
        }
        public IActionResult BearsPassing()
        {
            var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/2016");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<RootPassing>(response.Content);
            return View(root);
        }
        public IActionResult JaguarsPassing()
        {
            var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/2016");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<RootPassing>(response.Content);
            return View(root);
        }
        public IActionResult RamsPassing()
        {
            var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/passing-stats/offense/2016");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<RootPassing>(response.Content);
            return View(root);
        }
        



        //public class Embedded
        //{
        //    public List<TeamPassingStatsList> teamPassingStatsList { get; set; }
        //}
        //public class Links
        //{
        //    [JsonProperty("passing-stats")]
        //    public PassingStats passingstats { get; set; }
        //    public Self self { get; set; }
        //}

        //public class PassingStats
        //{
        //    public string href { get; set; }
        //}

        //public class Root
        //{
        //    public Embedded _embedded { get; set; }
        //    public Links _links { get; set; }
        //}

        //public class Self
        //{
        //    public string href { get; set; }
        //}

        //public class TeamPassingStatsList
        //{
        //    public string name { get; set; }
        //    public int passYards { get; set; }
        //    public int completions { get; set; }
        //    public int touchdowns { get; set; }
        //    public Links _links { get; set; }
        //}
    }

    
}
