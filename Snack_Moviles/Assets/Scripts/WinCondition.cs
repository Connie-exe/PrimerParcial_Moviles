using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject panel_win;
    //public GameObject panel_lose;
    void Start()
    {
        
    }
    void Update()
    {
        LoadNextLevel();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Timer.b_timeUp == false)
        {
            panel_win.SetActive(true);
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Créditos");
    }
}
