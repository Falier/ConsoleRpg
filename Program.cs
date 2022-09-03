using Console_rpg;
internal class Program
{
    private static void Main(string[] args)
    {
        int currentDay = 1;
        string command;
        Random random = new Random();

        int[,] inventory =  {
                        /*stone*/{ 0, 0},
                        /*wood*/{ 0, 0},
                        /*Pickaxe*/{0, 0},
                        /*Axe*/{0, 0}
                      };
        int energy = 60;
        int lifePoint = 100;

        bool gameOver = false;

        Command commands = new Command();

        //Item id, number, durability(null if no durability)

        //1 = Rock, 2 = Wood, 

        while (true)
        {
            while (!gameOver)
            {
                Console.WriteLine("Day {0}, type help to see a list of commands.", currentDay);
                command = Console.ReadLine() ?? "";

                if (command == "help" || command == "Help") commands.help();

                else if (command == "")
                {
                    Console.WriteLine("Please enter a valid command");
                    currentDay--;
                }
                else if (command == "gather" || command == "Gather")
                {
                    
                }
                else if (command == "explore" || command == "Explore")
                {
                    Console.WriteLine("Comming soon");
                }
                else if (command == "rest" || command == "Rest")
                {
                    if (energy == 100)
                    {
                        Console.WriteLine("You're already at max energy");
                    }
                    else
                    {
                        int checkEnergy = 100 - energy;
                        if (checkEnergy <= 20)
                        {
                            energy += checkEnergy;
                        }
                        else
                        {
                            energy += 20;
                        }
                        Console.WriteLine("You're now at {0} energy", energy);
                    }
                }
                else if (command == "stats" || command == "Stats")
                {
                    Console.WriteLine("[HP] : {0} \n[ENERGY] : {1}", lifePoint, energy);
                }
                else if (command == "Inventory" || command == "inventory")
                {
                    displayInventory();
                }
                else if (command == "Mine" || command == "mine")
                {
                    if (inventory[2, 0] != 0)
                    {
                        int minedRocks = random.Next(2, 5);
                        inventory[0, 0] += minedRocks;
                        inventory[2, 1]--;
                        Console.WriteLine("+{0} rocks", minedRocks);
                    }
                    else
                    {
                        Console.WriteLine("You need a pickaxe !");
                        currentDay--;
                    }
                }
                else if (command == "Chop" || command == "chop")
                {
                    if (inventory[3, 0] != 0)
                    {
                        int choppedWood = random.Next(2, 5);
                        inventory[1, 0] += choppedWood;
                        inventory[3, 1]--;
                        Console.WriteLine("+{0} wood", choppedWood);
                    }
                    else
                    {
                        Console.WriteLine("You need an axe !");
                        currentDay--;
                    }
                }
                else if (command == "GiveAxe")
                {
                    inventory[3, 0]++;
                    inventory[3, 1] = 20;
                    currentDay--;
                    Console.WriteLine(inventory[3, 0]);

                }
                else if (command == "checkDurability")
                {
                    Console.WriteLine(inventory[2, 1]);
                }
                else if(command == "test")
                {
                    commands.test();
                }
                currentDay++;
            }
        }

        void displayInventory()
        {
            /*Console.WriteLine("" +
                "[Stone] {0}" +
                "[Wood] {1}" +
                "[Pickaxe] {2]" +
                "[Axe] {3}",
                inventory[0,0],
                inventory[1,0],
                inventory[2,0],
                inventory[3,0]);*/
        }
    }
}