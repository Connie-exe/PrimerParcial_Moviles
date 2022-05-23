using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas_Btn : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        //Credits();
        //Game();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}
