using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image borde_timer;
    public Image timer;
    public Image shake;
    public float maxTime;
    public float timeLeft;
    public static bool b_timeUp;
    public GameObject character;
    public Image im_lose;
    //public GameObject panel_win;

    void Start()
    {
        borde_timer = GetComponent<Image>();
        timeLeft = maxTime;
        b_timeUp = false;
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
            character.SetActive(false);
            timer.gameObject.SetActive(false);
            borde_timer.gameObject.SetActive(false);
            shake.gameObject.SetActive(false);
            b_timeUp = true;
            im_lose.gameObject.SetActive(true);
        }
    }
}
