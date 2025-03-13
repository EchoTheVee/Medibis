using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtTabletPullup : MonoBehaviour
{
    public GameObject artTabletOn;
    public GameObject artTabletOff;
    public GameManager gm;
    //public string cheese;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.atIIU == true)
        {
            artTabletOff.SetActive(false);
            artTabletOn.SetActive(true);
            Cursor.visible = true;
        }

        if (gm.atIIU == false)
        {
            artTabletOn.SetActive(false);
            artTabletOff.SetActive(true);
            Cursor.visible = false;
        }
    }

}
