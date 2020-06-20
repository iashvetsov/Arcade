using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
        //Collide with Score object
        if(other.gameObject.tag == "Score")
        {
            Destroy(other.gameObject);
        }

        //Collide with Enemy
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
