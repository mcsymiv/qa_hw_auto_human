using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Human
    {
        public double WaterPrice = 2;
        public double ApplePrice = 7;
        public string Name;
        public int Apples;
        public int Water;
        public int EatApples;
        public int DrinkWater;
        public double Money;
        public int Hunger;
        public int Thirst;

        public void ShowParams()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name}'s params");
            Console.WriteLine($"Apples: {Apples}");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Water: {Water}");
            Console.WriteLine($"Thirst: {Thirst}");
            Console.WriteLine($"Money: {Money}\n");

            Console.WriteLine($"Can eat apples at once: {EatApples}\n");
            Console.WriteLine($"Can drink litres of water at once: {DrinkWater}\n");
            Console.Write("Press ENTER to procced");
            Console.ReadLine();
        }
        public void Eat(int amount)
        {

            if (Apples > amount && amount < EatApples)
            {
                Hunger -= amount;
                Apples -= amount;
                Console.WriteLine($"{Name} eat {amount} {(amount == 1 ? "apple" : "apples")}.\t");
            }
            else
            {
                Console.Write($"{Name}, you must buy more apples.\n");
            }
        }
        public void Drink(int amount)
        {
            if (Water > amount && amount < DrinkWater)
            {
                Thirst -= amount;
                Water -= amount;
                Console.WriteLine($"{Name} drank {amount} of water.\t");
            }
            else
            {
                Console.Write($"{Name}, you must buy more water.\n");
            }
        }
        public void SellItem(string item, int amount)
        {
            if (Apples < amount || Water < amount)
            {
                Console.WriteLine($"{Name} you don't have that much of a {item}");
            }
            else
            {
                if (item == "water")
                {
                    Money += WaterPrice*amount;
                    Water += amount;
                    Console.WriteLine($"{Name} sold {amount} {(amount == 1 ? "litre" : "liters")}.\t");

                }
                else if (item == "apple")
                {
                    Money += ApplePrice*amount;
                    Apples += amount;
                    Console.WriteLine($"{Name} sold {amount} {(amount == 1 ? "apple" : "apples")}.\t");
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }
        public void SellItem(string item, int amount, Human human)
        {
            if (item == "water")
            {
                if (Water > amount)
                {
                    human.Money -= WaterPrice*amount;
                    human.Water += amount;
                    Money += WaterPrice*amount;
                    Water -= amount;
                    Console.WriteLine($"{Name} sold {amount} {(amount == 1 ? "litre" : "liters")} to {human.Name}.\t");
                }
                else
                {
                    Console.WriteLine($"{Name} you don't have that much of a {item}");
                }
            }
            else if (item == "apple")
            {
                if (Apples > amount)
                {
                    human.Money -= ApplePrice*amount;
                    human.Apples += amount;
                    Money += ApplePrice*amount;
                    Apples -= amount;
                    Console.WriteLine($"{Name} sold {amount} {(amount == 1 ? "apple" : "apples")} to {human.Name}.\t");
                }
                else
                {
                    Console.WriteLine($"{Name}, you don't have that much of a {item}");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public void BuyItem(string item, int amount)
        {
            if (item == "apple")
            {
                if (ApplePrice * amount > Money)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    Apples += amount;
                    Money -= ApplePrice * amount;
                    Console.WriteLine("The deal is successful.\n");
                    Console.WriteLine($"{Name} bought {amount} {(amount == 1 ? "apple" : "apples")}.\t");
                }
            }
            else if (item == "water")
            {
                if (WaterPrice * amount > Money)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    Water += amount;
                    Money -= WaterPrice * amount;
                    Console.WriteLine("The deal is successful.\n");
                    Console.WriteLine($"{Name} bought {amount} {(amount == 1 ? "litre" : "liters")}.\t");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong.\n");
            }
        }

        public void BuyItem(string item, int amount, Human human)
        {
            if (item == "apple")
            {
                if (human.Apples < amount)
                {
                    Console.WriteLine($"{human.Name} don't have {item}. Try buy from others.\n");
                }
                else if(Money < ApplePrice * amount)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    human.Money += ApplePrice*amount;
                    human.Apples -= amount;
                    Money -= ApplePrice*amount;
                    Apples += amount;
                    Console.WriteLine("The deal is successful.\n");
                    Console.WriteLine($"{Name} bought {amount} {(amount == 1 ? "apple" : "apples")} from {human.Name}.\t");
                }
            }
            else if (item == "water")
            {
                if (human.Water < amount)
                {
                    Console.WriteLine($"{human.Name} don't have {item}. Try buy from others.\n");
                }
                else if (Money < WaterPrice * amount)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    human.Money += WaterPrice * amount;
                    human.Water -= amount;
                    Money -= WaterPrice*amount;
                    Water += amount;
                    Console.WriteLine("The deal is successful.\n");
                    Console.WriteLine($"{Name} bought {amount} {(amount == 1 ? "litre" : "liters")} from {human.Name}.\t");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
