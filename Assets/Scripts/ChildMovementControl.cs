using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMovementControl : MonoBehaviour
{
    private bool Arrived;
    private bool OnRoute;
    public float angleTurn;
    
    public void SetRoute(Transform point) {
        var targetRotation = Quaternion.LookRotation(point.position - transform.position);
        transform.rotation = (Quaternion.RotateTowards(transform.rotation, targetRotation, angleTurn));
    }
}
