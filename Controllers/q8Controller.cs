using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace SquashFellowsAPI.Controllers
{
    /// <summary>
    /// To get price of plushies in two sizes- small and large along with tax, subtotal and total price 
    /// </summary>

    /// <param name="small">for small size</param>
    /// <param name="large">for large size</param>

    /// <returns>
    /// It gives the value of all the required data
    /// </returns>

    /// <example>
    /// POST api/q8/squashfellows  -> (when entered small as 1 and large as 1) 1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
    /// </example>

    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        [HttpPost(template: "squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            double smallprice = small * 25.50;
            double largeprice = large * 40.50;
            double value = smallprice + largeprice;
            double tax = Math.Round(value * 0.13, 2);
            double total = value + tax;
            var culture = new CultureInfo("en-CA");
            string svalue = smallprice.ToString("C2", culture);
            string lvalue = largeprice.ToString("C2", culture);
            string pformat = value.ToString("C2", culture);
            string taxvalue = tax.ToString("C2", culture);
            string totalvalue = total.ToString("C2", culture);
            return $"{small} Small @ 25.50 = {svalue}; {large} Large @ 40.50 = {lvalue}; Subtotal = {pformat}; Tax = {taxvalue} HST; Total = {totalvalue}";
        }
    }
}