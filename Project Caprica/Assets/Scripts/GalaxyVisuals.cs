using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Caprica.Data;

namespace Caprica
{
    public class GalaxyVisuals : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public GameObject[] StarPrefabs; // index of array is a star type

        Galaxy galaxy;

        public void InitiateVisuals(Galaxy galaxy)
        {
            this.galaxy = galaxy;

            for(int i = 0; i < galaxy.GetNumStarSystems(); i++)
            {
                StarSystem ss = galaxy.GetStarSystem(i);

                GameObject go = Instantiate
                    (
                    StarPrefabs[ss.starType], 
                    ss.Position, 
                    Quaternion.identity, 
                    this.transform
                    );
            }
        }
    }
}
