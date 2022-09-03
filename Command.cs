using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_rpg
{
    internal class Command
    {
        Random random = new Random();

        public void test()
        {
            Console.WriteLine("Test working");
        }

        public void help()
        {
            Console.WriteLine(
                        "[Gather] : gather ressources\n" +
                        "[Explore] : try to find some interresting structures\n" +
                        "[Rest] : Rest a little bit to recover energy\n" +
                        "[Stats] : Show your stats\n" +
                        "[Inventory] : Open inventory\n" +
                        "[Craft] : Show craft menu. Type an item after the command to craft it\n" +
                        "[Drink] : Drink water\n" +
                        "[Eat] : Eat\n" +
                        "[Hunt] : Hunt creatures\n" +
                        "[Mine] : Use your pickaxe to mine some rocks\n" +
                        "[Chop] : Use your axe to chop some wood\n" +
                        "[Fish] : Use your fishing rod and try to catch a fish\n");
        }

        public void Gather(int rocks, int wood, int energy)
        {
            int gatheredRocks = random.Next(3);
            int gatheredWood = random.Next(4);
            rocks += gatheredRocks;
            wood += gatheredWood;
            energy -= 10;
            Console.WriteLine("+{0} wood, +{1} rocks", gatheredWood, gatheredRocks);
        }
    }
}