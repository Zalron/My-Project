﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Caprica
{
    public class Galaxy
    {
        private List<StarSystem> StarSystems;
        public StarSystem GetStarSystem(int StarSystemId)
        {
            return StarSystems[StarSystemId];
        }
    }
}
