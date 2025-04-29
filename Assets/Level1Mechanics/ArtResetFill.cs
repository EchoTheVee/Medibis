using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtResetFill : MonoBehaviour
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
                wa.tCArray[i].isActiveEraser = false;
                wa.tCArray[i].isActive = true;
                wa.tileArray[i].SetActive(true);
                wa.mrTabArray[i].material = wa.tCArray[i].on;
            }
        }
    }
}
