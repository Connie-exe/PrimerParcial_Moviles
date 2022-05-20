using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    private Quaternion baserotation = new Quaternion(0, 0, 1, 0);
    private void Start()
    {
        Giroscope.intance.EnabledGyro();
    }

    private void Update()
    {
        transform.localRotation = Giroscope.intance.GetGyroRotation() * baserotation;
    }
}
