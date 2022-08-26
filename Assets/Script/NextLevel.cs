using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    public GameObject PlayerChar;
    public bool InsideTriggerArea = false;
    public GameObject Door;
    public GameObject TargetDoor;


    void OnTriggerEnter2D(Collider2D Door)
    {
        Debug.Log("Entered");
        InsideTriggerArea = true;
    }


    void OnTriggerStay2D(Collider2D Door)
    {
        Debug.Log("Stayed");
        InsideTriggerArea = true;

        if (Input.GetButtonDown("Interact"))
        {


            Debug.Log("Using Door");
            PlayerChar.transform.position = new Vector4(TargetDoor.transform.position.x, TargetDoor.transform.position.y, TargetDoor.transform.position.z);



        }
    }

    void OnTriggerExit2D(Collider2D Door)
    {
        Debug.Log("Left");
        InsideTriggerArea = false;
    }


    void FixedUpdate()
    {


    }
}