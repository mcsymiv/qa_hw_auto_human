using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Driver : Human
    {
        public int DriverSkill;
        public bool HasCar;

        public void Drive()
        {
            Console.WriteLine(Name + " is driving");
        }
        public void Go(Human human)
        {
            if (HasCar)
            {
                Console.WriteLine($"{Name} driving to the {human.Name}\n");
            }
            else
            {
                Console.WriteLine($"{Name} goes to the {human.Name}\n");
                // MakeThirsty();
            }
        }
    }
}
