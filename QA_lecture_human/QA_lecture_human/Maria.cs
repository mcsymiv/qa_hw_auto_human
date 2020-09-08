using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Maria : Driver
    {
        public Maria()
        {
            // Human params
            this.Name = "Maria";
            this.Apples = 5;
            this.Water = 8;
            this.EatApples = 1;
            this.DrinkWater = 2;
            this.Thirst = 2;
            this.Hunger = 4;
            this.Money = 96;

            // Driver params
            this.HasCar = true;
            this.DriverSkill = 10;
        }
    }
}
