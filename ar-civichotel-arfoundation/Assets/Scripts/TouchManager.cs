using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public Material onLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                var rig = hit.collider.GetComponent<Rigidbody>();
                if(rig !=null)
                {
                    rig.GetComponent<MeshRenderer>().material = onLight;
                    rig.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
        }
        
    }
}
