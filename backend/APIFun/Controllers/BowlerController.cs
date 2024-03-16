using APIFun.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq; // Import LINQ namespace


namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp) {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers
                .Where(bowler => bowler.Team != null && (bowler.Team.TeamName == "Marlins" || bowler.Team.TeamName == "Sharks"))
                .Select(bowler => bowler.Team.TeamName)
                .Distinct()
                .ToArray();
            return bowlerData;
        }
    }
}
