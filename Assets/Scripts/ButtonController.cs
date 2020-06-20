using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    //Restart Game scene
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    //Start new game
    public void StartGame()
    {
        Time.timeScale = 1.0f;
        GameObject mainMenuPanel = GameObject.Find("Main Menu Panel");
        //Set main menu go out from camera
        if(mainMenuPanel.activeInHierarchy == true)
        {
            Animator animator = mainMenuPanel.GetComponent<Animator>();
            animator.SetBool("GameStart", true);
        }
    }
    //Go to Url
    public void GoToUrl(string url)
    {
        Application.OpenURL(url);
    }
    //Open shop
    public void OpenShop()
    {

    }
}