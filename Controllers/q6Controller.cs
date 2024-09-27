using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Q6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// The input should be the length of one side of the hexagon and find its area 
        /// </summary>

        /// <param name="area">The length of 1 side of Hexagon</param>

        /// <remarks>
        /// Instead of int, double is used
        /// </remarks>

        /// <returns>
        /// Area of Hexagon
        /// </returns>

        /// <example>
        /// GET localhost:xx/api/q6/hexagon?side=1  ->  2.598076211353316
        /// </example>

        //GET localhost:xx/api/q6/hexagon?side -> {S}
        [HttpGet(template: "hexagon")]
        public double q6(double area)
        {
            double hexarea = 3 * Math.Sqrt(3) * area * area;
            double actarea = hexarea / 2;
            return actarea;
        }
    }
}