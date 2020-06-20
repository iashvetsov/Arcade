using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float mooveSpeed; //enemy mooving speed
    private Engine engine;

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