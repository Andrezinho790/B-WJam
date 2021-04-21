using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionDatabase : MonoBehaviour
{
    public List<string> missionsTextList;
    public int currentMission = -1;
    public MissionManager missionManager;

    public void StartNextMission()
    {
        currentMission++;
        StartCoroutine(missionManager.StartMission(missionsTextList[currentMission]));
    }
}
