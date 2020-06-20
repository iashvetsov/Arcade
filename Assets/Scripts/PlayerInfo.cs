using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    //Params
    public int currentScore; //current score value

    //Objects
    public GameObject looseScreen; //Loose panel - Show when Player loose
    public GameObject hightScore_text; //Hight score text - Show hight score on scene
    public GameObject currentScore_text; //Current score text - Show current score on scene

    //Use for start game scene
    private void Start() 
    {
        //Init Hight score
        hightScore_text.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("HightScore").ToString();
        WriteHightScore();
    }

    //Use for Player loose action
    public void PlayerLoose()
    {
        //Show loos screen
        Animator animator = looseScreen.GetComponent<Animator>();
        animator.SetBool("ShowLoosScreen", true);

        //Write Hight Score
        WriteHightScore();
    }

    //Use for write new score record
    public void WriteHightScore()
    {
        int? currentHightScore = PlayerPrefs.GetInt("HightScore");
        if(currentScore > currentHightScore || currentHightScore == null)
        {
            PlayerPrefs.SetInt("HightScore", currentScore);
        }
    }

    //Use for update current score
    public void UpdateCurrentScore()
    {
        currentScore_text.GetComponent<TMPro.TextMeshProUGUI>().text = currentScore.ToString();
    }
}
