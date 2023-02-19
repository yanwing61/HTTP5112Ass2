using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Ass2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// From CCC 2016 J2 - Shifty Sum
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2017/stage%201/juniorEF.pdf
        /// This function calculate a shift sum, which is the sum of a number and the number we get by shifting.
        /// shifting a number to mean adding a zero at the end.
        /// </summary>
        /// <param name="N">The starting number input by he user (1<=N<=10000)</param>
        /// <param name="k">The number of times to shift N (0<=k<=5)</param>
        /// <returns>Output the integer which is the shifty sum of N by k</returns>
        /// <example>
        /// GET: /api/J2/ShiftingSum/12/0 -> 12
        /// GET: /api/J2/ShiftingSum/12/1 -> 132 (12 + 120)
        /// GET: /api/J2/ShiftingSum/12/3 -> 13332 (12 + 120 + 1200 + 12000)
        /// </example>


        [HttpGet]
        [Route("api/J2/ShiftingSum/{N}/{k}")]
        public int ShiftingSum(int N, int k)
        {
            int sum = N;
            int shift = 10;
            for(int i=1; i<=k; i++)
            {
                sum = sum + N * shift;
                shift *= 10;
            }
            return sum;

        }


    }
}
