using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStats
{
    class ArrayTools
    {
        // ------------------------------------------------------------------------------------------singles doubles triples hr divided by at bat
        string[] baseballStats = { "Singles:", "Doubles:", "Triples:", "Home Runs:", "at bat:" };
        public double[] stats;
        public ArrayTools()
        {
                stats = new double[5];
        }
        public void storeArray()
        {

            for (int i = 0; i < baseballStats.Length; i++)
            {
                Console.WriteLine("Please enter number of {0}", baseballStats[i]);
                stats[i] = Convert.ToDouble(Console.ReadLine());
            }

            calculateSLG();
        }
        public void calculateSLG()
        {
            double SLG;
            SLG = (stats[0] + (stats[1] * 2) + (stats[2] * 3) + (stats[3] * 4)) / stats[4];
            Console.WriteLine(SLG);
        }

    





//        double[] playerStats = new double[5];
//        public void PrintArray()
//            {
               
//                Console.WriteLine("Enter number of safe reaches:");
//                playerStats[0] = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter number of hits:");
//                playerStats[1] = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter number of times made to 2nd base");
//                playerStats[2] = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter number of times made to 3rd base");
//                playerStats[3] = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter number of HomeRuns made");
//                playerStats[4] = Convert.ToInt32(Console.ReadLine());

//                for (int i = 0; i<baseballStats.Length; i++)
//                {
//                    Console.WriteLine(baseballStats[i]);
//                    Console.WriteLine(playerStats[i]);
//                }
//}
    }
}
