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

        public LayerMask ClickableStarsLayerMask;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                // mouse was clikced -- is it on a star?

                // TODO: Ingore clikcs if over a UI element
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo, ClickableStarsLayerMask))
                {
                    // We hit something, and that something can ONLY be a clickable star
                    ClickableStar cs = hitInfo.collider.GetComponentInParent<ClickableStar>();
                    if (cs == null)
                    {
                        Debug.LogError("Our star doesn't have a ClickableStar component?");
                        return;
                    }
                    Debug.Log("Clicked star: " + cs.name);
                    ViewManager.Instance.ShowView(ViewManager.Instance.SystemView);
                }
                //GameObject.FindObjectOfType<SystemView>().gameObject.SetActive(true);
                
            }
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
