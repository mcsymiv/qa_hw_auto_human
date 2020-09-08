using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Menu
    {
        Vasya vasya = new Vasya();
        Petro petro = new Petro();
        Alex alex = new Alex();
        Maria maria = new Maria();
        Human person;
        public int AskCharacter()
        {
            int option;
            do
            {
                Console.WriteLine("1. Vasya.");
                Console.WriteLine("2. Petya.");
                Console.WriteLine("3. Alex.");
                Console.WriteLine("4. Maria.");
                Console.WriteLine("5. Exit.");
                Console.Write("Select your character:\t");
            } while (!int.TryParse(Console.ReadLine(), out option) || option > 5 || option < 1);
            return option;
        }

        public void ShowCharacter(int option)
        {
            switch (option)
            {
                case 1:
                    person = vasya;
                    Console.WriteLine($"You've choose {vasya.Name}");
                    vasya.ShowParams();
                    break;
                case 2:
                    person = petro;
                    Console.WriteLine($"You've choose {petro.Name}");
                    petro.ShowParams();
                    break;
                case 3:
                    person = alex;
                    Console.WriteLine($"You've choose {alex.Name}");
                    alex.ShowParams();
                    break;
                case 4:
                    person = maria;
                    Console.WriteLine($"You've choose {maria.Name}");
                    maria.ShowParams();
                    break;
                case 5:
                    Console.WriteLine("Goodbye");
                    break;
            }
        }

        public int AskAction()
        {
            int action;
            Console.WriteLine("What do you want to do? ");
            do
            {
                Console.WriteLine("1. Drink water.");
                Console.WriteLine("2. Eat apples.");
                Console.WriteLine("3. Buy water or apples.");
                Console.WriteLine("4. Buy water or apples from someone.");
                Console.WriteLine("5. Sell water or apples.");
                Console.WriteLine("6. Sell water or apples to someone.");
                Console.WriteLine("7. Go to some one.");
                Console.WriteLine("8. Show characters params.");
                Console.WriteLine("9. Exit.");
                Console.Write("Select your option:\t");
            } while (!int.TryParse(Console.ReadLine(), out action) || action > 9 || action < 1);
            return action;
        }

        public void Action(int action)
        {
            int amount = 0,
                item = 0;
            Human someone;
            switch (action)
            {
                case 1:
                    do
                    {
                        Console.Write("How much of water you want to drink?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount > person.DrinkWater || amount < 1);
                    person.Drink(amount);
                    Console.ReadLine();
                    break;
                case 2:
                    do
                    {
                        Console.Write("How much of apples you want to drink?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount > person.EatApples || amount < 1);
                    person.Eat(amount);
                    Console.ReadLine();
                    break;
                case 3:
                    SellBuyAction(false, 0, 0);
                    break;
                case 4:
                    someone = AskWho("Select your bussines partner:\t");
                    SellBuyAction(false, 0, 0, someone);
                    break;
                case 5:
                    SellBuyAction(true, 0, 0);
                    break;
                case 6:
                    someone = AskWho("Select your bussines partner:\t");
                    SellBuyAction(true, 0, 0, someone);
                    break;
                case 7:
                    someone = AskWho("To whom do you wanna go?:\t");
                    break;
                case 8:
                    person.ShowParams();
                    break;
            }
        }
        public void SellBuyAction(bool sell, int amount, int item)
        {
            if (!sell)
            {
                do
                {
                    Console.WriteLine("1. Apples");
                    Console.WriteLine("2. Water");
                    Console.Write("What do you want to buy?");
                } while (!int.TryParse(Console.ReadLine(), out item) || item > 2 || item < 1);

                if (item == 1)
                {
                    do
                    {
                        Console.Write("How many apples do you want to buy?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1);
                    person.BuyItem("apples", amount);
                    Console.ReadLine();
                }
                else
                {
                    do
                    {
                        Console.Write("How many litres of water do you want to buy?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1);
                    person.BuyItem("water", amount);
                    Console.ReadLine();
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("1. Apples");
                    Console.WriteLine("2. Water");
                    Console.Write("What do you want to sell?");
                } while (!int.TryParse(Console.ReadLine(), out item) || item > 2 || item < 1);

                if (item == 1)
                {
                    do
                    {
                        Console.Write("How many apples do you want to sell?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1 || person.Apples > amount);
                    person.SellItem("apples", amount);
                    Console.ReadLine();
                }
                else
                {
                    do
                    {
                        Console.Write("How many litres of water do you want to sell?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1 || person.Water > amount);
                    person.SellItem("water", amount);
                    Console.ReadLine();
                }
            }
        }
        public Human AskWho(string question)
        {
            Human someone = new Human();
            // Console.WriteLine("Remember you can't buy from yourself and sell to yourself");
            int option;

            do
            {
                if(person.Name == "Vasya")
                {
                    Console.WriteLine("1. Petro");
                    Console.WriteLine("2. Alex");
                    Console.WriteLine("3. Maria");
                }
                else if(person.Name == "Petro")
                {
                    Console.WriteLine("1. Vasya");
                    Console.WriteLine("2. Alex");
                    Console.WriteLine("3. Maria");
                }
                else if(person.Name == "Alex")
                {
                    Console.WriteLine("1. Vasya");
                    Console.WriteLine("2. Petro");
                    Console.WriteLine("3. Maria");
                }
                else if(person.Name == "Maria")
                {
                    Console.WriteLine("1. Vasya");
                    Console.WriteLine("2. Petro");
                    Console.WriteLine("3. Alex");
                }
                Console.Write($"{question}");
            } while (!int.TryParse(Console.ReadLine(), out option) || option > 4 || option < 1);

            switch (option)
            {
                case 1:
                    if(option == 1 && person.Name != "Vasya")
                    {
                        someone = vasya;
                    }
                    else
                    {
                        someone = petro;
                    }
                    break;
                case 2:
                    if (option == 2 && (person.Name == "Alex" || person.Name == "Maria"))
                    {
                        someone = petro;
                    } 
                    else if(option == 2 && person.Name != "Alex")
                    {
                        someone = alex;
                    }
                    break;
                case 3:
                    if (option == 3 && person.Name != "Maria")
                    {
                        someone = maria;
                    }
                    else 
                    {
                        someone = alex;
                    }
                    break;
            }
            return someone;
        }
        public void SellBuyAction(bool sell, int amount, int item, Human someone)
        {
            if (!sell)
            {
                do
                {
                    Console.WriteLine("1. Apples");
                    Console.WriteLine("2. Water");
                    Console.Write("What do you want to buy?\t");
                } while (!int.TryParse(Console.ReadLine(), out item) || item > 2 || item < 1);

                if (item == 1)
                {
                    do
                    {
                        Console.Write("How many apples do you want to buy?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1);
                    person.BuyItem("apple", amount, someone);
                    Console.ReadLine();
                }
                else
                {
                    do
                    {
                        Console.Write("How many litres of water do you want to buy?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1);
                    person.BuyItem("water", amount, someone);
                    Console.ReadLine();
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("1. Apples");
                    Console.WriteLine("2. Water");
                    Console.Write("What do you want to sell?\t");
                } while (!int.TryParse(Console.ReadLine(), out item) || item > 2 || item < 1);

                if (item == 1)
                {
                    do
                    {
                        Console.Write("How many apples do you want to sell?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1 || person.Apples < amount);
                    person.SellItem("apple", amount, someone);
                    Console.ReadLine();
                }
                else
                {
                    do
                    {
                        Console.Write("How many litres of water do you want to sell?\t");
                    } while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1 || person.Water < amount);
                    person.SellItem("water", amount, someone);
                    Console.ReadLine();
                }
            }
        }
    }
}
