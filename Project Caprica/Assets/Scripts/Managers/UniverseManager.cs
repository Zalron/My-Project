using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Caprica.Data;

namespace Caprica
{
    public class UniverseManager : MonoBehaviour
    {
        // This scripts is responsible for holding the main Galaxy data object triggering file save/loads or triggering the generation of a new galaxy.
        // Maybe also gets callback from end turn button?

       
        void Start() // Start is called before the first frame update
        {
            Generate();
        }

        

        Galaxy galaxy;

        void Update() // Update is called once per frame
        {

        }

        public void Generate()
        {
            Debug.Log("UniverseManager::Generate -- Generating a new Galaxy");

            galaxy = new Galaxy();
            galaxy.Generate();

            //Tell our visual system to spawn the graphics
            ViewManager.Instance.GalaxyVisuals.InitiateVisuals(galaxy);
        }
    }
}
