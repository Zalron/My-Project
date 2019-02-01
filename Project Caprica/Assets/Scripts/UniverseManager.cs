using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Caprica
{
    public class UniverseManager : MonoBehaviour
    {
        // This scripts is responsible for holding the main Galaxy data object triggering file save/loads or triggering the generation of a new galaxy.
        // Maybe also gets callback from end turn button?

        // Start is called before the first frame update
        void Start()
        {
            Generate();
        }

        Galaxy galaxy;

        // Update is called once per frame
        void Update()
        {

        }
        public void Generate()
        {
            Debug.Log("UniverseManager::Generate -- Generating a new Galaxy");

            galaxy = new Galaxy();
            galaxy.Generate();
        }
    }
}
