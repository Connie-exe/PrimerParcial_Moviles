using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giroscope : MonoBehaviour
{
    private CharacterController controller;
    void Start()
    {
       if(SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
       else
        {
            Debug.Log("Your cellphone doesn't support Gyroscope");
        }
    }
    void Update()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
        
    }

    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
