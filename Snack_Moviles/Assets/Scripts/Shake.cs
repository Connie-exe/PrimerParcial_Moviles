using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    float accelerometerUpdateInterval = 1.0f / 60.0f;
    public float lowPassKernelWidthInSeconds;
    float shakeDetectionThreshold = 2.0f;
    float lowPassFilterFactor;
    Vector3 lowPassValue;

    //private Animator anim_open;
    //private Animator anim_open_1;

    public GameObject salida_1;
    public GameObject salida_2;
    void Start()
    {
        lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
        shakeDetectionThreshold *= shakeDetectionThreshold;
        lowPassValue = Input.acceleration;
        //anim_open = salida_1.gameObject.GetComponent<Animator>();
        //anim_open_1 = salida_2.gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        Vector3 acceleration = Input.acceleration;
        lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
        Vector3 deltaAcceleration = acceleration - lowPassValue;

        if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
        {
            //anim_open.Play("open_anim");
            //anim_open_1.Play("open_1_anim");
            salida_1.gameObject.SetActive(false);
            salida_2.gameObject.SetActive(false);
            Debug.Log("Shake event detected at time " + Time.time);
        }
    }


}
