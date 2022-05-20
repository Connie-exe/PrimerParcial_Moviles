using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giroscope : MonoBehaviour
{
    private static Giroscope instance;
    public static Giroscope intance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Giroscope>();
                if(instance == null)
                {
                    instance = new GameObject("Spawed GyroManager", typeof(Giroscope)).GetComponent<Giroscope>();
                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }
    
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;

    public void EnabledGyro()
    {
        if(gyroActive)
        {
            return;
        }

        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }    
    }
   
    private void Update()
    {
        rotation = gyro.attitude;

    }

    public Quaternion GetGyroRotation()
    {
        return rotation;
    }


}
