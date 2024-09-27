using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    /// <summary>
    /// To add number and modify the dates acoordingly
    /// </summary>

    /// <param name="days">the number entered by the user that they want to modify in the current date</param> 

    /// <returns>
    /// it responds with the modified date acoording to user's in input "yyyy-MM-dd" format
    /// </returns>

    /// <example>
    /// GET api/q7/timemachine?days=1  -> it will display tomorrow's date as user entered 1 i.e. 2024-09-26
    /// </example>

    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase 
    {
        /// GET ocalhost:xx/api/q7/timemachine?days=1 
        [HttpGet(template: "timemachine")]
        public string timemachine(int days)
        {
            DateTime current = DateTime.Now;
            DateTime modify = current.AddDays(days);
            return modify.ToString("yyyy-MM-dd");
        }
    }
}
