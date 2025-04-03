using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtReset : MonoBehaviour
{
    public WorldAltering wa;
    public bool iitp;
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gm.burnoutNumber = 0;
        iitp = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            iitp = false;
        }
    }

    private void Update()
    {
        if (iitp)
        {

        for (int i = 0; i < wa.tCArray.Length; i++)
        {

                //if (iitp)
                //{
                wa.tCArray[i].isActiveEraser = true;
            wa.tileArray[i].SetActive(false);
            wa.mrTabArray[i].material = wa.tCArray[i].off;
            //}

        }
        }
    }
}
