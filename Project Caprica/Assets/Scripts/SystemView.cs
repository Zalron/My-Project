using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Caprica
{
    public class SystemView : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Instance = this;
            gameObject.SetActive(false);
        }

        static public SystemView Instance;

        // Update is called once per frame
        void Update()
        {

        }
    }
}
