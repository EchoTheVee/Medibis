using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldAltering : MonoBehaviour
{
    public GameObject[] tileArray;
    public TileCoordination[] tCArray;
    public MeshRenderer[] mrArray;
    public MeshRenderer[] mrTabArray;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < tCArray.Length; i++)
        {
            if (tCArray[i].isActive)
            {
                tileArray[i].SetActive(true);
                mrArray[i].material = tCArray[i].on;
                mrTabArray[i].material = tCArray[i].on;
            }
            if (tCArray[i].isActiveEraser)
            {
                tileArray[i].SetActive(false);
                mrTabArray[i].material = tCArray[i].off;
            }
            if (tCArray[i].isActiveBlue)
            {
                tileArray[i].SetActive(true);
                mrArray[i].material = tCArray[i].blue;
                mrTabArray[i].material = tCArray[i].blue;
            }
            if (tCArray[i].isActiveRed)
            {
                tileArray[i].SetActive(true);
                mrArray[i].material = tCArray[i].red;
                mrTabArray[i].material = tCArray[i].red;
            }

        }


    }
}
