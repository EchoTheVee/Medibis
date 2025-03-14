using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public float movespeed;
    public float turnspeed;
    public int MaxStamina = 100;
    public int Stamina = 100;
    public int BurnoutThreshold = 0;
    public float maxStamina = 100f;
    public float currentStamina;
    void Start()
    {
        currentStamina = maxStamina;
    }

    public void RestoreStamina(float amount)
    {
        currentStamina = Mathf.Min(currentStamina + amount, maxStamina);
        Debug.Log("Stamina Restored! Current Stamina: " + currentStamina);
    }
}

