using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public float velocidadDeRotacion;
    public Transform pivote;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(pivote.transform.position, Vector3.up, velocidadDeRotacion * Time.deltaTime);   
    }
}
