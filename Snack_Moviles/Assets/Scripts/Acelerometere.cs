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
        if(SystemInfo.supportsAccelerometer)
        {
            Vector3 tilt = Input.acceleration;

            if (isFlat)
            {
                tilt = Quaternion.Euler(-90, 0, 0) * tilt;
            }
            rigid.AddForce(tilt * speed);
        }
        else
        {
            Debug.Log("Your cellphone doesn't support accelerometer");
        }
        

        //Vector3 dir = Vector3.zero;
        //dir.y = Input.acceleration.y;
        //dir.z = Input.acceleration.x;
        //if (dir.sqrMagnitude > 1)
        //{
        //    transform.Rotate(new Vector3(Input.acceleration.x, Input.acceleration.y, 0) * Time.deltaTime * speed);
        //}
    }
}
