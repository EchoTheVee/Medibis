using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCoordination : MonoBehaviour
{
    public GameManager gm;
    public MeshRenderer mr;
    public Material on;
    public Material off;
    public Material red;
    public Material blue;

    public bool isActiveEraser;
    public bool isActive;
    public bool isActiveRed;
    public bool isActiveBlue;

    
    //public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        isActive = !isActive;

        if (gm.eraserSelected)
        {
            isActiveEraser = true;
            isActive = false;
            isActiveRed = false;
            isActiveBlue = false;
        }

        if (gm.greenSelected)
        {
            isActiveEraser = false;
            isActive = true;
            isActiveRed = false;
            isActiveBlue = false;
        }

        if (gm.redSelected)
        {
            isActiveEraser = false;
            isActive = false;
            isActiveRed = true;
            isActiveBlue = false;
        }

        if (gm.blueSelected)
        {
            isActiveEraser = false;
            isActive = false;
            isActiveRed = false;
            isActiveBlue = true;
        }
    }
}
