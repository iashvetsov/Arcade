using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
#region Properties
    [SerializeField]
    private Engine engine; //Engine instance
    private PlayerInfo playerInfo; //PlayerInfo Instance
    public float mooveSpeedValue; //moove speed value
    private float mooveSpeed; //move speed variable to change direction
    private bool isRDir; //Is right direction of moove
#endregion

#region Init
    private void Awake() 
    {
        //Create Engine component
        if(GetComponent<Engine>() == null)
        {
            engine = gameObject.AddComponent<Engine>() as Engine;
        }
        else
        {
            engine = GetComponent<Engine>();
        }

        //Get PlayerInfo component
        playerInfo = GetComponent<PlayerInfo>();
    }
#endregion
    //Use for fixed update iterations
    private void FixedUpdate()
    {
        ChangeMoveDirection();
        engine.MoovingHorizontal(mooveSpeed);
    }

    //Change move direction
    private void ChangeMoveDirection()
    {
        if(isRDir)
        {
            mooveSpeed = mooveSpeedValue; //posiviv speed
        }
        else
        {
            mooveSpeed = -mooveSpeedValue; //negative speed
        }
    }

    //On collision events
    private void OnCollisionEnter(Collision other) 
    {
        //Collide with board
        if(other.gameObject.tag == "Board")
        {
            ChangeDirection();
        }

        //Collide with enemy
        if(other.gameObject.tag == "Enemy")
        {
            //Call Player Loose Event
            playerInfo.PlayerLoose();
        }    
        //Collide with Score
        if(other.gameObject.tag == "Score")
        {
            //Add current score
            playerInfo.currentScore += other.gameObject.GetComponent<ScoreController>().scoreValue;
            //destroy score gameObject
            Destroy(other.gameObject);
            playerInfo.UpdateCurrentScore();
        }   
    }

    //Change Direction
    public void ChangeDirection()
    {
        isRDir = !isRDir;
    }
}
