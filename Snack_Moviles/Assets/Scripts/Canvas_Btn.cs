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
        Menu();
        Game();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Créditos");
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}
