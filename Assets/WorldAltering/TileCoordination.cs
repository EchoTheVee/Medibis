using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCoordination : MonoBehaviour
{
    public GameManager gm;
    public MeshRenderer mr;
    public PlayerController pc;
    public Material on;
    public Material off;
    public Material red;
    public Material blue;

    public bool isActiveEraser;
    public bool isActive;
    public bool isActiveRed;
    public bool isActiveBlue;

    //public Collider myCollider;


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

    private void OnMouseEnter()
    {
        Debug.Log("MOUSE IS INSIDE");
    }

    private void OnMouseDown()
    {

        
        Debug.Log("ISCLICKING!");

        if (gm.burnoutNumber != 50)
        {
            pc.audioSource.PlayOneShot(pc.audioClip3);

            isActive = !isActive;
            gm.burnoutNumber = gm.burnoutNumber + 5;

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
}
