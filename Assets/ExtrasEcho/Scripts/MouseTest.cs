using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Clicked Mouse");
        }
    }
    private void OnMouseEnter()
    {
        Debug.Log($"Mouse is on {gameObject.name}");
    }
}
