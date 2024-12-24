using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRescueAdventure
{
    public static class Game
    {
        public static double CurrentFuel = 1000;
        public static GameStatus Status = GameStatus.InProgress;
        public static List<Planet> Planets { get; set; }
        public static int NumberOfAstronautsSaved = 0;
        public static int NumberOfPlanetsVisited = 0;
        public static int RefuelCount = 0;
        public static Dictionary<string, string> AstronautsSaved_ = new Dictionary<string, string>();

        public static void StartGame()
        {
            Console.WriteLine("Welcome, astronaut. You have decided to be a hero, but a heros path is not an easy one. Many dangers await. What will be your first action?");
            Console.WriteLine("Before you start, here is your current status: ");
            CheckGameStatus();
            Console.WriteLine("Now, choose what you want to do next: ");
            DisplayMenu();
        }

        public static void EndGame()
        {
            Console.WriteLine("Thank you for playing.");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("" +
                "1: Check status\n" +
                "2: See list of planets\n" +
                "3: Regain fuel (D A N G E R O U S)\n" +
                "4: Host a battle royale (E V I L)\n" +
                "5: View the astronauts you saved\n" +
                "6: End game");


            Console.WriteLine("(Type the number)");
            GetUserInput();
        }

        public static void GetUserInput()
        {

            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    CheckGameStatus();
                    DisplayMenu();
                    break;
                case 2:
                    SeeListOfPlanets();
                    break;
                case 3:
                    Console.WriteLine("Are you sure you want to do this? You should only resort to this method if you have nothing left. (y/n)");
                    string ___answer = Console.ReadLine();
                    if (___answer == "n")
                    {
                        DisplayMenu();
                    }
                    RegainFuel();
                    break;
                case 4:
                    HostBattleRoyale();
                    break;
                case 5:
                    ViewSavedAstronauts();
                    break;
                case 6:
                    Console.WriteLine("Are you sure? (y/n)");
                    string __answer = Console.ReadLine();
                    if (__answer == "n")
                    {
                        DisplayMenu();
                    }
                    EndGame(); 
                    break;
                    
            }
        }  

        public static void RegainFuel()
        {
            if (RefuelCount > 0)
            {
                Console.WriteLine("You already regained fuel once. You can not do it again, or you will die.");
            }
            Console.WriteLine("\n\nWhat you are about to do is going to either cost you your life, or save the lives of many others.");
            Console.WriteLine("You have the following options. How much fuel will you try to acquire?");
            Console.WriteLine("\n1: 100 fuel (20% change of death)\n2: 200 fuel (30% chance of death) \n3: 300 fuel (45% chance of death)\n4: 400 fuel (60% chance of death)\n5: 550 fuel (75% chance of death)\n 6: 700 fuel (90% chance of death) \n7: 1500 fuel (99% chance of death; basically suicide.)");
            Console.WriteLine("K E E P  I N  M I N D:\nYou will only have the chance to regain your fuel ONCE. This is your first and last chance; choose wisely (choose the number)");
            wrongFuelFormat:
            if (!int.TryParse(Console.ReadLine(), out int answer))
            {
                Console.WriteLine("Write an integer.");
                goto wrongFuelFormat;
            }

            if (answer < 1 || answer > 7)
            {
                Console.WriteLine("Invalid. Choose from between 1 and 7.");
                goto wrongFuelFormat;
            }

            Random rand = new Random();

            void RegainFuelProcess()
            {
                Console.WriteLine("Your body is being deprived of it's essence. Your soul is being absorbed and turned into fuel.");
            }

            switch (answer)
            {
                case 1:
                    RegainFuelProcess();
                    if (rand.Next(1, 11) == 1)
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    else
                    {
                        Console.WriteLine("The pain was awful, but you withstood it. Congratulations on 100 extra fuel.");
                        CurrentFuel += 100;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    break;
                case 2:
                    RegainFuelProcess();
                    if (rand.Next(1, 6) == 1 )
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    else
                    {
                        Console.WriteLine("The pain was one that you had never felt before, it was devastating, but you withstood it. Congratulations on 200 extra fuel.");
                        CurrentFuel += 200;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    break;
                case 3:
                    RegainFuelProcess();
                    if (rand.Next(1, 10) == 1 || rand.Next(1, 10) == 2)
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    else
                    {
                        Console.WriteLine("The pain was horrible. It was so bad that you thought you were going to die.  Congratulations on 300 extra fuel.");
                        CurrentFuel += 300;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    break;
                case 4:
                    RegainFuelProcess();
                    if (rand.Next(1, 11) == 1 || rand.Next(1, 11) == 2 || rand.Next(1, 11) == 3 || rand.Next(1, 11) == 4)
                    {
                        Console.WriteLine("It was incredibly painful. There was a moment when you wanted to give up, but you pulled through. Congratulations on 400 extra fuel.");
                        CurrentFuel += 400;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    else
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    break;
                case 5:
                    RegainFuelProcess();
                    if (rand.Next(1, 5) == 1)
                    {
                        Console.WriteLine("It was the worst thing you had ever felt. You could feel your soul being sucked out of your body, you hated every moment of it, and despised yourself for choosing this, but you pulled through. Congratulations on 550 extra fuel.");
                        CurrentFuel += 550;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    else
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    break;
                case 6:
                    RegainFuelProcess();
                    if (rand.Next(1, 11) == 1)
                    {
                        Console.WriteLine("The pain you felt was unexplainable through words. You wished you were dead. Crying and screaming, you barely survived. Congratulations on 700 extra fuel.");
                        CurrentFuel += 700;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    else
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    break;
                case 7:
                    RegainFuelProcess();
                    if (rand.Next(1, 101) == 1)
                    {
                        Console.WriteLine("The pain was so horrifying that you wished to die the moment you felt it. You tried to stab and strangle yourself, but you couldn't even move a muscle. You passed out, but survived, nonetheless. Congratulations on 1500 extra fuel.");
                        CurrentFuel += 1500;
                        RefuelCount += 1;
                        DisplayMenu();
                    }
                    else
                    {
                        Console.WriteLine("You couldn't withstand the inhuman pain. You died with honor.");
                        Status = GameStatus.Failure;
                        EndGame();
                    }
                    break;
            }
        }

        public static void HostBattleRoyale()
        {
            Random rand = new Random();

            if (NumberOfAstronautsSaved > 1) 
            {
                int index = rand.Next(AstronautsSaved_.Count);
                KeyValuePair<string, string> randomPair = AstronautsSaved_.ElementAt(index);

                Console.WriteLine(AstronautsSaved_.Count());
                //string bruh = AstronautsSaved_.Keys.ElementAt(1);

                Console.WriteLine("After years of traversing the space in silence, you slowly begun to go mad. You started to abuse the astronauts you saved. It got to the point that you made them kill eachother until only one was left");
                Console.WriteLine($"{randomPair.Key}, from planet {randomPair.Value}, the last astronaut standing, realized how evil you were, and gave it all they had to kill you.", randomPair.Key, randomPair.Value);
                Console.WriteLine($"They succeeded, and returned to their home planet.");
                Console.WriteLine("And your corpse still floats in space till this day.");
                Console.WriteLine("ENDING: FAILURE");
                Status = GameStatus.Failure;
                EndGame();
            }
            else
            {
                Console.WriteLine("You are not eligible to do this, because you have not saved any astronauts.");
                DisplayMenu();
            }
        }

        public static void ViewSavedAstronauts()
        {
            if (NumberOfAstronautsSaved > 1)
            {
                Console.WriteLine("These are the astronauts you saved: They are very thankful to you.");
                foreach(var astronaut in AstronautsSaved_)
                {
                    Console.WriteLine($"Astronaut: {astronaut}.");
                }
                DisplayMenu();
            }
            else
            {
                Console.WriteLine("You are not eligible to do this, because you have not saved any astronauts.");
                DisplayMenu();
            }
        }

        public static void SeeListOfPlanets()
        {
            Console.WriteLine("Here are the list of planets and the amount of astronauts on them to save:\n");
            int count = 1;
            foreach(var planet in Planets)
            {
                Console.WriteLine($"{count}: Planet: {planet.Name}, Distance: {planet.Distance}, Number of astronauts: {planet.Astronauts.Count()}.");
                count++;
            }

            Console.WriteLine("Now, please enter the number of the planet you want to visit:");
            wrongFormat:
            if (!int.TryParse(Console.ReadLine(), out int answer))
            {
                Console.WriteLine("Write an integer!");
                goto wrongFormat;
            }

            if(answer < 1 || answer > 11)
            {
                Console.WriteLine("Invalid. Choose from between 1 and 11.");
                goto wrongFormat;
            }
            
            foreach (var _planet in Planets) {
                if (_planet.Id == answer)
                {
                    Planet planet = new Planet() { Id = answer, Name = _planet.Name, Distance = _planet.Distance, Astronauts = _planet.Astronauts};
                    TravelToPlanet(planet);
                } 
            }
        }

        public static void CheckGameStatus()
        {
            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========================================");
            Console.WriteLine("|         Space Rescue Adventure       |");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Home Planet: Earth");
            Console.WriteLine($"Current Fuel: {CurrentFuel}");
            Console.WriteLine($"Astronauts Saved: {NumberOfAstronautsSaved}, Planets Visited: {NumberOfPlanetsVisited}");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\n\n\n");
        }


        public static void TravelToPlanet(Planet planet)
        {
            Console.WriteLine($"There are {planet.Astronauts.Count()} astronauts on this planet, and the distance is {planet.Distance}. If you go, you must save all of them. Keep in mind: Saving one astronaut = 10 fuel. \n. The distance also affects the fuel wasted.\nSo, will you go or not?");
            Console.WriteLine("1: Yes\n2: No\n(type the number)");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine();
            }
            else
            {
                DisplayMenu();
            }


            if (planet.Distance <= 100)
            {
                CurrentFuel -= 40;
            } else if(planet.Distance > 100 & planet.Distance <= 500)
            {
                CurrentFuel -= 80;
            } else if(planet.Distance > 500 & planet.Distance <= 1000)
            {
                CurrentFuel -= 150;
            } else if(planet.Distance > 1000 & planet.Distance <= 2000)
            {
                CurrentFuel -= 250;
            }
            else
            {
                CurrentFuel -= 350;
            }

            CurrentFuel -= 10 * planet.Astronauts.Count();

            if (CurrentFuel <= 0)
            {
                CurrentFuel = 0;
                Console.WriteLine($"Astronaut, your fuel was running out, so you had no choice but to return to your home planet. What to do now? You have run out of fuel completely. You have 2 options:\n" +
                    $"1. G I V E  U P. You have visited {NumberOfAstronautsSaved} planets and saved {NumberOfAstronautsSaved} astronauts. Are you happy with this result, or...\n" +
                    "2. R E G A I N  F U E L. If you still have a drop of hope left in you. You may try to regain fuel, which is incredibly dangerous. Once you start, there is no going back." +
                    "\n(Type the number)");

                int finalAnswer = Convert.ToInt32(Console.ReadLine());

                if (finalAnswer == 1)
                {
                    Console.Write($"You have given up. But you still accomplished something. You saved {NumberOfAstronautsSaved} astronauts: ");
                    foreach(var astronaut in AstronautsSaved_)
                    {
                        Console.Write(astronaut + ", ");
                    }
                    Console.WriteLine("\nGAME RESULT : SUCCESS");
                    Status = GameStatus.Success;
                    EndGame();
                }
                else
                {
                    if (RefuelCount > 0)
                    {
                        Console.WriteLine("You already regained fuel once. You can not do it again, or you will die.");
                        Console.WriteLine("Your only choice was to give up, and that's what you did.");
                        Console.Write($"You have given up. But you still accomplished something. You saved {NumberOfAstronautsSaved} astronauts: ");
                        foreach (var astronaut in AstronautsSaved_)
                        {
                            Console.Write(astronaut + ", ");
                        }
                        Console.WriteLine("\nGAME RESULT : SUCCESS");
                        Status = GameStatus.Success;
                        EndGame();
                    }
                    RegainFuel();
                }
            }

            foreach(var astronaut in planet.Astronauts)
            {
                astronaut.isRescued = true;
            }

            NumberOfAstronautsSaved += planet.Astronauts.Count();
            NumberOfPlanetsVisited += 1;

            Console.WriteLine($"The {planet.Astronauts.Count()} have all been saved.");
            Console.WriteLine("Here are the astronauts you saved: ");
            foreach(var astronaut in planet.Astronauts)
            {
                Console.WriteLine(astronaut.Name);
                AstronautsSaved_[astronaut.Name] = astronaut.Planet;
            }

            
            Console.WriteLine($"You now have {CurrentFuel} fuel left.");
            DisplayMenu();
        }
    }
}
