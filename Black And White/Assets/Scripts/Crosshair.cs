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
    public MissionDatabase missionDB;
    ValidateItem valItem;
    public MissionManager missionManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(missionDB.currentMission);
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {    
            
            if (hit.transform.CompareTag("InteractItem"))
            {
                valItem = hit.transform.GetComponent<ValidateItem>();
                if (missionDB.currentMission == valItem.id)
                {
                    crossHair.color = Color.white;
                    goInteract.SetActive(true);
                    

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Destroy(hit.transform.gameObject);
                        missionManager.completeMission();
                        missionDB.StartNextMission();
                    }
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
