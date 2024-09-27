using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Cube of the number
        /// </summary>

        /// <param name="number">It is input of user i.e. the input whose cube has to be identified</param>
        /// <param name="cubenum">It returns the output i.e. the cube </param>
      
        /// <returns>
        /// Returns cube of the number
        /// </returns>

        /// <example>
        /// GET localhost:xx/api/q3/cube   ->  64
        /// GET localhost:xx/api/q3/cube   ->  -64
        /// GET localhost:xx/api/q3/cube  ->  1000
        /// </example>
        /// 
        //GET localhost:xx/api/q3/cube -> "Cube"
        [HttpGet(template: "cube/{number}")]
        public int q3(int number)
        {
            int cubenum = number * number * number;
            return cubenum;
        }
    }
}
