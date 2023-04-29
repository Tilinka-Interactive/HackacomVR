using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICrowdController : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPos;
    [SerializeField] Children[] Children;
    [SerializeField] Transform EndPos;
    
    void Start()
    {
            
    }

    public void SpawnKids()
    {
     
            InvokeRepeating("SpawnRound", 0, 0.2f);   
    }

    public void SpawnRound() {
        for (int i = 0; i < Children.Length / SpawnPos.Length; i++)
        {
                  
        }
    }
}
