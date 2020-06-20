using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDetector : MonoBehaviour, IPointerClickHandler
{
    PlayerController playerController; //PlayerController Instance
    //Init
    private void Awake() 
    {
        //Find Player on Scene 
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    //Click detection
    public void OnPointerClick(PointerEventData eventData)
    {
        //change direction by clicking on the panel
        playerController.ChangeDirection();
        //Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
    }
}