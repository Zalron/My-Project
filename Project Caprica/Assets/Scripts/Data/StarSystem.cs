using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Caprica
{
    namespace Data
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

            public Vector3 Position;

            private const int MAX_PLANETS = 8;

            private Planet[] planets;

            enum StarClass
            {
                REDSTAR = -1, 
                YELLOWSTAR = 0,
                WHITESTAR = 1,
                BLUESTAR = 2,
            }

            public int starType = (int)StarClass.YELLOWSTAR;

            public StarSystemGraphic StarSystemGraphic;

            public string Name;

            public Planet GetPlanet(int PlanetIndex)
            {
                return planets[PlanetIndex];
            }

            public void Generate(int starType = 0/* Galactic age/richness info?*/)
            {
                //Generate 0 to Max planets, weighting planet class based on StarType + distance from the Sun
                this.starType = starType;
            }

            public void Save()
            {
                //Some kind of file handle?
            }

            public void Load()
            {
                //Some kind of file handle?
            }

        }
    }
}
