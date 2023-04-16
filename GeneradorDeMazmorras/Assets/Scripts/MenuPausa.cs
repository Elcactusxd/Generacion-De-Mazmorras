using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;

    public void Pause()
    {
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
    }
    
    public void Back()
    {
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
