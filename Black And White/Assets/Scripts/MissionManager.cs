using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    private Animator animator;
    public TextMeshProUGUI missionText; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public IEnumerator StartMission(string textMission)
    {
        yield return new WaitForSeconds(1.5f);
        missionText.text = textMission;
        animator.SetTrigger("IsOpen");
    }

    public void completeMission()
    {
        animator.SetTrigger("Completed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
