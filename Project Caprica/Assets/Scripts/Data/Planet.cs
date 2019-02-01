using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Caprica
{
    namespace Data
    {
        public class PlanetGraphic
        {

        }
        public enum PlanetType
        {
            ASTEROID, GASGIANT, CONTINENTAL, GAIAN, OCEANIC, BARREN, RADIATED, TOXIC, DESERT, ARID, TUNDRA, JUNGLE
        }

        public enum PlanetSize
        {
            TINY, SMALL, MEDIUM, LARGE, HUGE
        }

        public enum PlanetRichness
        {
            VERYPOOR, POOR, ABUNDANT, RICH, VERYRICH
        }

        public class Planet
        {
            public PlanetGraphic PlanetGraphic;

            public string Name;

            public readonly int PlanetIndex;


            // Planet Traits might become a class that can apply their own logic?
            public enum PlanetTrait
            {
                GOLDDEPOSIT, ARTIFACTWORLD
            }

            List<PlanetTrait> PlanetTraits;

            PlanetType PlanetType;

            public PlanetSize PlanetSize;

            public Colony Colony;
        }
    }
}
