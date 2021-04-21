using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    public float range = 30f;
    public Transform cam;
    public Image crossHair;
    public GameObject goInteract;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if (hit.transform.CompareTag("InteractItem"))
            {
                crossHair.color = Color.white;
                goInteract.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(hit.transform.gameObject);
                }
            }
            else
            {
                goInteract.SetActive(false);
                crossHair.color = Color.black;
            }        
        }

        

    }
}
