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

        //Create an integer representing the index for burger, drink, sides and dessert
        public string Get(int burger, int drink, int side, int dessert)
        {
          //Create an integer representing total calories and assign a value
            int totalCalories = 0;
            //Create an if statement if burger is equal to 1, then total calories for burger will be 0 plus 461 calories and so on as stated in the question
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
            //Create an if statement also for drinks like the burger, the same logic applies
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
            ////Create an if statement also for sides like the burger

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
            //Return the total calories count for each integer
            string response = "Your total calorie count is " + totalCalories;
            return response;
        }

      
    }
}
