using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Caprica
{

    public class StarSystemGraphic
    {
        // int? string? sprite? 
    }
    public class StarSystem
    {
        public StarSystem()
        {
            planets = new Planet[MAX_PLANETS];
            //GeneratePlanets();
        }

        private const int MAX_PLANETS = 8;

        private Planet[] planets;

        enum starClass
        {
            YELLOWSTAR,
            REDSTAR,
            WHITESTAR,
            BLUESTAR,
        }

        public StarSystemGraphic StarSystemGraphic;

        public string Name;

        public Planet GetPlanet(int PlanetIndex)
        {
            return planets[PlanetIndex];
        }

        private void GeneratePlanets()
        {
            //Generate 0 to Max planets, weighting planet class based on StarType + distance from the Sun
        }
    }
}
