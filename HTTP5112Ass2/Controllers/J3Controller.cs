using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Ass2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// CCC 2018 J3 - Are we there yet?
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2018/stage%201/juniorEF.pdf
        /// Along a straight road are five cities.
        /// This function is to e to calculate a distance table that indicates the distance between any two of the cities.
        /// </summary>
        /// All the parameters should be positive integers less than 1000.
        /// <param name="city12">The distance between city 1 and 2 </param>
        /// <param name="city23">The distance between city 2 and 3 </param>
        /// <param name="city34">The distance between city 3 and 4 </param>
        /// <param name="city45">The distance between city 4 and 5 </param>
        /// <returns>
        /// The result should be in 5 lines, with the i-th line (1 ≤ i ≤ 5) containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.
        /// </returns>
        /// <example>
        /// GET: api/J3/Road/3/10/12/5 ->
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// </example>

        [HttpGet]
        [Route("api/J3/Road/{city12}/{city23}/{city34}/{city45}")]
        public IEnumerable<string> Road (int city12, int city23, int city34, int city45)
        {
        // I know the codes are so repetitive but this is the only way I can figure out to solve this problem so far.

            int city13 = city12 + city23;
            int city14 = city13 + city34;
            int city15 = city14 + city45;
            int city24 = city23 + city34;
            int city25 = city24 + city45;
            int city35 = city34 + city45;

            int[] cityone = { 0, city12, city13, city14, city15 };
            int[] citytwo = { city12, 0, city23, city24, city25 };
            int[] citythree = { city13, city23, 0, city34, city35 };
            int[] cityfour = { city14, city24, city34, 0, city45 };
            int[] cityfive = { city15, city25, city35, city45, 0 };

            string outputline1 = "";
            string outputline2 = "";
            string outputline3 = "";
            string outputline4 = "";
            string outputline5 = "";

            for (var i=0; i<cityone.Count(); i++)
            {
                outputline1 = outputline1 + cityone[i] + " ";
            }
            
            for (var i = 0; i < citytwo.Count(); i++)
            {
                outputline2 = outputline2 + citytwo[i] + " ";
            }

            for (var i = 0; i < citythree.Count(); i++)
            {
                outputline3 = outputline3 + citythree[i] + " ";
            }

            for (var i = 0; i < cityfour.Count(); i++)
            {
                outputline4 = outputline4 + cityfour[i] + " ";
            }

            for (var i = 0; i < cityfive.Count(); i++)
            {
                outputline5 = outputline5 + cityfive[i] + " ";
            }

            IEnumerable<string> output = new string[] { outputline1, outputline2, outputline3, outputline4, outputline5 };
  
            return output;

        }
    }
}
