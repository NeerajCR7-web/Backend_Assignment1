using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace q1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request and provides a response message.
        /// </summary>

        ///< returns > An HTTP response with a body indicating the usage.</ returns >

        /* <example>
           GET localhost:xx/api/q1/welcome -> Welcome to 5125!
           </example> */

        // GET localhost:xx/api/q1/welcome -> "Welcome to 5125!"
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
         
        }
    }
}

