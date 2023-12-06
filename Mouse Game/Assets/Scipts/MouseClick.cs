using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check for mouse buttons being pressed
        if (Input.GetMouseButtonDown(0)) //if left button is pressed 
        {
            Debug.Log("Left Click");    //Show in console
        }

        if (Input.GetMouseButtonDown(1)) //If right button is pressed 
        {
            Debug.Log("Right Click");   //Show in console
        }

        if (Input.GetMouseButtonDown(2)) //If middle button is pressed
        {
            Debug.Log("Middle Click");  //Show in console
        }

    }
}
