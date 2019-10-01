using System;

namespace LuckyRoulette
{
    public class LetsPlayRoulette
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random random = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };
            int guess;
            int attempts = 0;
            int bet;
            int money = 500;
            while (money != 0)
            {
                Console.WriteLine("\nLucky Roulette");
                Console.WriteLine("\nMoney: $" + money + "\tAttempts: " + attempts);
                Console.WriteLine("\nEnter your guess");
                Console.WriteLine("\n1. Even \n2. Odd \n3. 1 to 18" +
                    "\n4. 19 to 36 \n5. Red \n6. Black \n7. 1st 12" +
                    "\n8. 2nd 12 \n9. 3rd 12\n");
                guess = Convert.ToInt32(Console.ReadLine());
                bool check = guess <= 9 && guess >= 1;
                //Verifier to ensure user input is valid
                if (check == false)
                {
                    Console.WriteLine("\nYou did not enter a valid bet.\n");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    bet:
                    Console.WriteLine("\nEnter an amount to bet\n");
                    bet = Convert.ToInt32(Console.ReadLine());
                    //Verifier to ensure bet is less then total money
                    if (bet > money)
                    {
                        Console.WriteLine("\nYou don't have that much champ!");
                        Console.WriteLine("\nPress enter to try again.");
                        Console.ReadLine();
                        goto bet;
                    }
                    else
                    {
                        money -= bet;
                        int roll = random.Next(0, 36);
                        string randomColor = color[r.Next(color.Length)];
                        bool even = roll % 2 == 0;
                        if (((guess == 1) && (even == true)) || ((guess == 2) && (even == false)) || ((guess == 5) && (randomColor == "Red")) || ((guess == 6) && (randomColor == "Black")))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nWINNER! $" + (bet * 2));
                            Console.WriteLine("Press enter to continue");
                            money += (bet * 2);
                            attempts++;
                            Console.ReadKey();
                        }
                        else if ((guess == 3) && ((roll > 0) && (roll < 19)))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nWINNER! $" + (bet * 2));
                            Console.WriteLine("\nPress enter to continue");
                            money += (bet * 2);
                            attempts++;
                            Console.ReadKey();
                        }
                        else if ((guess == 4) && ((roll > 18) && (roll < 37)))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nWINNER! $" + (bet * 2));
                            Console.WriteLine("\nPress enter to continue");
                            money += (bet * 2);
                            attempts++;
                            Console.ReadKey();
                        }
                        else if (((guess == 7) && (roll > 0 && roll < 13)) || ((guess == 8) && (roll > 12 && roll < 25)) || ((guess == 9) && (roll > 24 && roll < 37)))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nWINNER! $" + (bet * 2));
                            Console.WriteLine("\nPress enter to continue");
                            money += (bet * 3);
                            attempts++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nLOSER! -$" + (bet));
                            Console.WriteLine("\nPress enter to continue");
                            attempts++;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("\nYou're broke.");
                                Console.WriteLine("\nPress enter to continue");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                Console.Clear();
            }
        }
    }
}
