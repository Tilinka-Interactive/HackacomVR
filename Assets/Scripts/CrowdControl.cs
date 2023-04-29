using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdControl : MonoBehaviour
{
    [SerializeField] private Transform[] WaypointsList;
    private void OnTriggerEnter(Collider other)
    {
        int randB = Random.Range(0, 3);
        if (other.CompareTag("ChildCrowd")) {
            MoveToLocation(other);
            if(randB < 1) StopRun(other);
        }
    }

    private void MoveToLocation(Collider other) { 
        int rand = Random.Range(0, WaypointsList.Length);
        other.GetComponent<ChildMovementControl>().SetRoute(WaypointsList[rand]);
        
    }
    private void StopRun(Collider other)
    {
        other.GetComponent<playanimation>().ChangeAnimation();
    }
}