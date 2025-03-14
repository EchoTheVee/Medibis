using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public int Burnout;
    public int StaminaBoost { get; private set; }

    public static int collectibleCount = 0; // Tracks how many have been collected
    public float staminaRestoreAmount = 20f; // Amount of stamina restored

    void OnTriggerEnter(Collider other)
    {
        PlayerStamina playerStamina = other.GetComponent<PlayerStamina>();

        if (playerStamina != null)
        {
            collectibleCount++; // Increase the collectible count
            playerStamina.RestoreStamina(staminaRestoreAmount); // Restore draw stamina
            Debug.Log("Collected! Total: " + collectibleCount + " | Stamina Restored: " + staminaRestoreAmount);
            
        }

      if (GameObject.Find("Player"))
      {
        Destroy(gameObject); // Remove this collectible
      }
    }
}
