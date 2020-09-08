using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Alex : Pedestrian
    {
        public Alex()
        {
            // Human params
            this.Name = "Alex";
            this.Apples = 15;
            this.Water = 28;
            this.EatApples = 3;
            this.DrinkWater = 2;
            this.Thirst = 5;
            this.Hunger = 9;
            this.Money = 296;

            // Pedestrian params
            this.WalkingSpeed = 4;
        }
    }
}
