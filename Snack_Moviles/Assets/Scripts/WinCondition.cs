using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject im_win;
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
            im_win.SetActive(true);
            Destroy(other.gameObject);
            LoadNextLevel();
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
