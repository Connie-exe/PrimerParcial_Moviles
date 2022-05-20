using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometere : MonoBehaviour
{
    public bool isFlat = true;
    public float speed;
    private Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
         Vector3 tilt = Input.acceleration;
         tilt = Quaternion.Euler(-90, 0, 0) * tilt;
         rigid.AddForce(tilt * speed);                      
    }
}
