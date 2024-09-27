using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>

        /// <param name="integer">Input by user</param>

        /// <returns>
        ///  response as "Shh... The secret is {integer}"
        /// </returns>

        /// <remarks>
        /// Heading: Content-Type: application/json
        /// </remarks>

        /// <example>
        /// POST localhost:xx/api/q5/secret   ->  "Shh.. the secret is 5"  
        /// POST localhost:xx/api/q5/secret  ->  "Shh.. the secret is -200" 
        /// </example>
        
        //POST localhost:xx/api/q5/secret -> "Shh.. the secret is number"
        [HttpPost(template: "secret")]
        public string q5([FromBody] int integer)
        {

            return $"Shh.. the secret is {integer}";
        }
    }
}
