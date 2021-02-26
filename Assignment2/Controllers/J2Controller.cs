using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    //Create controller from J2
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        ////Create an integer representing the index m and n
        public string Get(int m, int n)
        {
            int result;
            if ((m + n) >= 10)
            {
                int highestValue = 0;
                int lowestValue = 0;
                if (m > n)

                {
                    highestValue = m;
                }
                else
                {
                    highestValue = n;
                }

                if (m == highestValue)
                {
                    lowestValue = 10 - n;
                }
                else
                {
                    lowestValue = 10 - m;
                }
                if (highestValue > (10 - 1))
                {
                    highestValue = (10 - 1);
                }
                result = highestValue - lowestValue + 1;
            }
            else
            {
                result = 0;
               
            }
            string response; 
            if (result ==1)
            {
                response = "There is " + result + "way to get the sum of 10";
            }
            else
            {
                response = "There are " + result + "ways to get the sum of 10";
            }
            return response;
        }
    }
}
