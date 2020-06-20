using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public float mooveSpeed; //score mooving speed
    public int scoreValue; //score value
    private Engine engine; //engine instance

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
    }
    #endregion

    //Use for fixed update iterations
    private void FixedUpdate()
    {
        //Enemy mooving
        engine.MoovingVertical(mooveSpeed);
    }
}
