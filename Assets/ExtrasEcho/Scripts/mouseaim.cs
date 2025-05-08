using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseaim : MonoBehaviour
{
    // Variables
    public Transform player;

    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;

    public GameManager gm;

    bool lockedCursor = true;


    void Start()
    {
      

        // Lock and Hide the Cursor
        Cursor.visible = false;


        //Cursor.lockState = CursorLockMode.Locked;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {

        if (lockedCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
        // Collect Mouse Input


        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        

        // Rotate the Camera around its local X axis

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        


        // Rotate the Player Object and the Camera around its Y axis

        if (!gm.atIIU)
        {
            player.transform.Rotate(Vector3.up * inputX);
            lockedCursor = true;
        }
        else
        {
            lockedCursor = false;
        }
    }
}

