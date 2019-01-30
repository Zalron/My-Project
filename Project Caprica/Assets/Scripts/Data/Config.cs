using System;
using System.Collections.Generic;
using UnityEngine;

namespace Caprica
{
    public class Config
    {
        // Values are coded here for now, but the goal will be to load in from a config file that is modable.

        public static int GetInt(string Parameter)
        {
            switch (Parameter)
            {
                case "PLANET_MAX_POPULATION_TINY":
                    return 4;
                case "PLANET_MAX_POPULATION_SMALL":
                    return 6;
                case "PLANET_MAX_POPULATION_MEDIUM":
                    return 10;
                case "PLANET_MAX_POPULATION_LARGE":
                    return 12;
                case "PLANET_MAX_POPULATION_HUGE":
                    return 16;
                default:
                    Debug.LogError("GetInt: No option for"+Parameter);
                    return 0;
            }
        } 
    }
}
