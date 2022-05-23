using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Acelerometere : MonoBehaviour
{
    public bool isFlat = true;
    public float speed;
    private Rigidbody rigid;
    public Image im_shake;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShakeNotif"))
        {
            im_shake.gameObject.SetActive(true);
        }       
    }
}
