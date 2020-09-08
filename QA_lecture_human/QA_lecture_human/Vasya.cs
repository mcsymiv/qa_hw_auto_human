using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Vasya : Cyclist
    {
        public Vasya()
        {
            // Human params
            this.Name = "Vasya";
            this.Apples = 23;
            this.Water = 14;
            this.EatApples = 3;
            this.DrinkWater = 5;
            this.Thirst = 3;
            this.Hunger = 2;
            this.Money = 100;

            // Cyclist params
            this.HasBike = false;
        }
    }
}
