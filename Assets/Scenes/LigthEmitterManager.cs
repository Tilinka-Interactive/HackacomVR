using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthEmitterManager : MonoBehaviour
{
    [SerializeField] private GameObject lightt;
    void Start()
    {

    }

    // Update is called once per frame
    public void StartLightTest() {
        Tween();       
    }

    private void Tween()
    {
        LeanTween.cancel(lightt);
        LeanTween.moveZ(lightt, 30, 2f).setEasePunch().setRepeat(20); 

    }
}
