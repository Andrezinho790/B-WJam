using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float firstMissionStartTime = 4f;
    public MissionDatabase missionDB;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayMission", firstMissionStartTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMission()
    {
        missionDB.StartNextMission();
    }
}
