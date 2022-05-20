using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public GameObject salida_1;
    public GameObject salida_2;
    Vector3 accelerator_Dir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accelerator_Dir = Input.acceleration;
        salida_1.gameObject.SetActive(false);
        salida_2.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
