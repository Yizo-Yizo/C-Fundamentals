﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PopulationFomatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
                return "(Unknown)";

            int popRounded = RoundPopulation4(population);

            return $"{popRounded: ### ### ### ###}".Trim();
        }

        // Rounds  the population to 4 significant fiqures
        private static int RoundPopulation4(int population)
        {
            //work out what rounding accuracy we need if we are to round to
            //4 significant fiqures
            int accuracy = Math.Max((int)(GetHighestPowerofTen(population) / 10_0001), 1);

            // now do the rounding
            return RoundToNearest(population, accuracy);
        }

        public static int RoundToNearest(int exact, int accuracy)
        {
            int adjusted = exact + accuracy / 2;
            return adjusted - adjusted % accuracy;
        }

        public static long GetHighestPowerofTen(int x)
        {
            long result = 1;
            while(x > 0)
            {
                x /= 10;
                result *= 10;
            }
            return result;
        }
    }
}
