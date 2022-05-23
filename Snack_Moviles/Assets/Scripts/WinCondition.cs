using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject im_win;
    public Image timer;
    public Image timer_border;
    public Image shake; 
    //public GameObject panel_lose;
    void Start()
    {
        
    }
    void Update()
    {        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Timer.b_timeUp == false)
        {
            im_win.SetActive(true);
            Destroy(other.gameObject);
            timer.gameObject.SetActive(false);
            timer_border.gameObject.SetActive(false);
            shake.gameObject.SetActive(false);
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
        SceneManager.LoadScene("Credits");
    }
}
