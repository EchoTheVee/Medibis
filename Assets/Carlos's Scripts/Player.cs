using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public float movespeed;
    public float turnspeed;
    public int MaxStamina = 100;
    public int Stamina = 100;
    public int BurnoutThreshold = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * movespeed * VerticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnspeed * HorizontalInput * Time.deltaTime);
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
    }
    public void Draw(int amount)
    {
        if (Stamina > BurnoutThreshold)
        {
            Stamina -= amount;
            Debug.Log($"You drew for {amount} stamina. Remaining stamina: {Stamina}");
            if (Stamina <= BurnoutThreshold)
            {
                Debug.Log("You've hit burnout! You need to recover.");
            }
        }
        else
        {
            Debug.Log("collect inspiration to recover.");
        }
    }
    public void IncreaseStamina(int amount)
    {
        Stamina = Math.Min(Stamina + amount, MaxStamina);
    }
    // Start is called before the first frame update
   
}
