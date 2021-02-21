using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    //Create controller from J1 Menu
    public class J1Controller : ApiController
    {
        //Get Action to calculate calories 
        [HttpGet]
        [Route("api/j1/menu/{burger}/{drink}/{side}/{dessert}")]
        public string Get(int burger, int drink, int side, int dessert)
        {
            int totalCalories = 0;

            if (burger == 1)
            {
                totalCalories = totalCalories + 461; 
            }
            else if (burger == 2)
            {
                totalCalories = totalCalories + 431;
            }
            else if (burger == 3)
            {
                totalCalories = totalCalories + 420;
            }
            else if (burger == 4)
            {
                totalCalories = totalCalories + 0;
            }
            if (drink == 1)
            {
                totalCalories = totalCalories + 130;
            }
            else if (drink == 2)
            {
                totalCalories = totalCalories + 160;
            }
            else if (drink == 3)
            {
                totalCalories = totalCalories + 118;
            }
            else if (drink == 4)
            {
                totalCalories = totalCalories + 0;
            }

            if (side == 1)
            {
                totalCalories = totalCalories + 100;
            }
            else if (side == 2)
            {
                totalCalories = totalCalories + 57;
            }
            else if (side == 3)
            {
                totalCalories = totalCalories + 70;
            }
            else if (side == 4)
            {
                totalCalories = totalCalories + 0;
            }
            if (dessert == 1)
            {
                totalCalories = totalCalories + 167;
            }
            else if (dessert == 2)
            {
                totalCalories = totalCalories + 266;
            }
            else if (dessert == 3)
            {
                totalCalories = totalCalories + 75;
            }
            else if (dessert == 4)
            {
                totalCalories = totalCalories + 0;
            }

            string response = "Your total calorie count is " + totalCalories;
            return response;
        }

      
    }
}
