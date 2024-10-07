using Business;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CharacterGenaration.Controllers
{
    public class RaceController : Controller
    {
        private RaceManager raceManager;

        public RaceController(IServiceProvider serviceProvider)
        {
            this.raceManager = serviceProvider.GetService<RaceManager>();
            if (raceManager == null) {
                throw new Exception("ERROR: raceManager == null");
            }
        }

        [HttpGet]
        [Route("GetAllRaces")]
        public IList<Race> GetAllRaces()
        {
            return raceManager.GetAllRaces();
        }

        [HttpGet()]
        [Route("GetRaceById/:id")]
        public Race GetRaceById(string id)
        {
            return raceManager.GetRaceById(id);
        }
    }
}
