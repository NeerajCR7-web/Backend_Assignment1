using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace q2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request and provides a response message.
        /// </summary>

        /// <param name="name">
        /// Here, the user would enter the input i.e. the name which he wants in the output
        /// </param>

        /// <returns>Hi {name}!</returns>

        /// <example>
        /// GET localhost:xx/api/q2/greeting -> "Hi abc!"
        /// GET localhost:xx/api/q2/greeting -> "Hi xyz!"
        /// </example>

        // GET localhost:xx/api/q2/greeting?name=Gary -> "Hi Gary!"
        // GET localhost:xx/api/q2/greetingname=Ren%C3%A9e-> "Hi Renée!"
        [HttpGet(template: "greeting")]
        public string q2(string name)
            
        {
            return $"Hi {name}!";
        }
    }
}
