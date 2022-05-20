using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image borde_timer;
    public float maxTime;
    public float timeLeft;
    //public GameObject panel_lose;
    //public GameObject panel_win;

    void Start()
    {
        borde_timer = GetComponent<Image>();
        timeLeft = maxTime;
    }   
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            borde_timer.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Debug.Log("You lose!");
        }
    }
}
