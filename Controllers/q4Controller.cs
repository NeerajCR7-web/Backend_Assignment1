using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message i.e. Who's there?.
        /// </summary>

        /// <returns>An HTTP response with a body indicating the usage.</returns>

        /// <example>
        /// POST api/q4/knockknock  ->  Who's there?
        /// </example>

        //POST : api/q4/knockknock -> "Who's there?"
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }
    }
}
