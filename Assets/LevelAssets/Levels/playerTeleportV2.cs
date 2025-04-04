using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleportV2 : MonoBehaviour
{
    public GameObject Destination;
    public Transform player;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        player.transform.position = Destination.transform.position;
        Debug.Log("teleport");

        }

    }
}

