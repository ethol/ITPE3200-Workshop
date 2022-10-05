using Microsoft.AspNetCore.Mvc;

namespace Git_Workshop.Controllers
{
    public class TechnobableController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            var words1 = new List<string> { "Hyperdimentional", "Electron", "hyperspace", "Pocket Universe", "Photon", "Wave", "Beam" };
            var words2 = new List<string> { "Combuster", "Emitter", "Dampener", "Array", "Android", "Cyborg", "Torpedo", "Sail", "Terraformner",
           "Elevator" };
            Random R = new Random();

            return $"{words1[R.Next(0, words1.Count)]} {words2[R.Next(0, words2.Count)]}";
        }
    }


}
