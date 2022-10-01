using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private int scene = 0;

    public void StartGame()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("nooo");
    }
}
