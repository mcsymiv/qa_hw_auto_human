using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Cyclist : Human
    {
        public bool HasBike;
        public int BikeSkill;

        public void Go(Human human)
        {
            if (HasBike)
            {
                Console.WriteLine($"{Name} cycling to the {human.Name}\n");
            }
            else
            {
                Console.WriteLine($"{Name} goes to the {human.Name}\n");
            }
        }
    }
}
