using Microsoft.AspNetCore.Mvc;

namespace Git_Workshop.Controllers
{
    public class SwallowCalculatorController : ControllerBase
    {
        [Route("SwallowCalculator/{weight}/{capacity}")]
        public ActionResult<double> CalculateRequiredNumberOfSwallows(double weight, double capacity)
        {
            return Ok(weight / capacity);
        }
    }
}
