using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectible : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public int Burnout;
    public int StaminaBoost { get; private set; }

    public Collectible(int staminaBoost)
    {
        StaminaBoost = staminaBoost;
    }

    public void Collect(Player player)
    {
        player.Stamina = Math.Min(player.Stamina + StaminaBoost, player.MaxStamina);
        Debug.Log($"Collected an inspiration boost! Stamina increased by {StaminaBoost}. Current stamina: {player.Stamina}");
    }

// Start is called before the first frame update
void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
