using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Ass2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// From CCC 2006 J1 - The New CCC (Canadian Calorie Counting)
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
        /// The function lets us know the total calories of the meal depending the user's choice from the four course menu.
        /// </summary>
        /// <param name="burger">It represents the burger choice number (1-4).</param>
        /// <param name="drink">It represents the drink choice number (1-4).</param>
        /// <param name="side">It represents the side choice number (1-4).</param>
        /// <param name="dessert">It represents the dessert choice number (1-4).</param>
        /// <returns>
        /// Output a string indicates the total calories of the meal.
        /// </returns>
        /// <example>
        /// GET: /api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        /// GET: /api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// GET: /api/J1/Menu/4/1/1/2 -> "Your total calorie count is 496"
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerCal = { 461, 431, 420, 0 };
            int[] drinkCal = { 130, 160, 118, 0 };
            int[] sideCal = { 100, 57, 70, 0 };
            int[] dessertCal = { 167, 266, 75, 0 };

            int total = burgerCal[burger-1] + drinkCal[drink-1] + sideCal[side-1] + dessertCal[dessert-1];
            return "Your total calorie count is " + total.ToString();
        }
    }
}
