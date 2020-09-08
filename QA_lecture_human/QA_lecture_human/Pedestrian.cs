using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Pedestrian : Human
    {
        public int WalkingSpeed;

        public void Go(Human human)
        {
            Console.WriteLine($"{Name} goes to the {human.Name}\n");
        }
    }
}
