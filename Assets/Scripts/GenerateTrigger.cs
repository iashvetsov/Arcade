using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTrigger : MonoBehaviour
{
    [SerializeField]
    Generator scoreGenerator; //Score generator instance
    [SerializeField]
    Generator enemyGenerator; //Enemy generator instance
    
    private void OnTriggerEnter(Collider other) {
    //Generate Score prefab
        if(other.gameObject.tag == "Score")
        {
            scoreGenerator.Generate();
        }

        //Generate Enemy prefab
        if(other.gameObject.tag == "Enemy")
        {
            enemyGenerator.Generate();
        }
    }
}