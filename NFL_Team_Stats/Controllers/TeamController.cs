using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using NFL_Team_Stats.Models;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using RestSharp;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using Autofac.Core;
using SimpleInjector;
using static System.Net.WebRequestMethods;

namespace NFL_Team_Stats.Controllers
{
    public class TeamController : Controller
    {
        
        [HttpPost]
        public IActionResult MenuTeams(string teamName, string selectedYear)
        {
            ViewData["teamName"] = teamName;
            ViewData["selectedYear"] = selectedYear;
            return View();
        }

        

        public readonly Embedded _embedded;
        public TeamController()
        {
            _embedded = new Embedded();
        }
        
        [HttpPost]
        public IActionResult TeamWinsLosses(string team, string year)
        {
            
            var nflURL = "https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/win-stats/" + year;
            //var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/win-stats/2016");
            var client = new RestClient(nflURL);
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<Root>(response.Content);
            int index = 15;
            for (int i = 0; i < 32; i++)
            {
                if (root._embedded.teamWinStatsList[i].name.Contains(team))
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

        [HttpPost]
        public IActionResult TeamRushingStats(string team, string year)
        {

            var nflURL = "https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/rushing-stats/offense/" + year;
            //var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/win-stats/2016");
            var client = new RestClient(nflURL);
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<Root>(response.Content);
            int index = 15;
            for (int i = 0; i < 32; i++)
            {
                if (root._embedded.teamRushingStatsList[i].name.Contains(team))
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
        public IActionResult TeamReceivingStats(string team, string year)
        {

            var nflURL = "https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/receiving-stats/offense/" + year;
            //var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/win-stats/2016");
            var client = new RestClient(nflURL);
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            var root = JsonConvert.DeserializeObject<Root>(response.Content);
            int index = 15;
            for (int i = 0; i < 32; i++)
            {
                if (root._embedded.teamReceivingStatsList[i].name.Contains(team))
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





        //public IActionResult IndexBrowns()
        //{
        //    var client = new RestClient("https://nfl-team-stats.p.rapidapi.com/v1/nfl-stats/teams/win-stats/2016");
        //    var request = new RestRequest();
        //    request.AddHeader("X-RapidAPI-Key", "9437551e4fmshc7ef06cdb6cae1ap1e1f9ejsnbb926ca5a7ba");
        //    request.AddHeader("X-RapidAPI-Host", "nfl-team-stats.p.rapidapi.com");
        //    var response = client.Execute(request);
        //    Console.WriteLine(response.Content);
        //    var root = JsonConvert.DeserializeObject<Root>(response.Content);
        //    return View(root);
        //}













    }
}
