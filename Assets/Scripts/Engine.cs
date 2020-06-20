using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
#region Properties
    [SerializeField]
    private new Rigidbody rigidbody; //rigidbody component
#endregion

#region Init
    private void Awake() {

        //Create Rigibody component
        if(GetComponent<Rigidbody>() == null)
        {
            rigidbody = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        }
        else
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        //Not use gravity
        rigidbody.useGravity = false;

        //freeze rotation
        rigidbody.freezeRotation = true;
    }
#endregion

    //Mooving
    public void MoovingHorizontal(float moveSpeed)
    {
        rigidbody.MovePosition(transform.position + transform.right * moveSpeed * Time.deltaTime);
    }

    public void MoovingVertical(float moveSpeed)
    {
        rigidbody.MovePosition(transform.position + transform.up * moveSpeed * Time.deltaTime);
    }
}
