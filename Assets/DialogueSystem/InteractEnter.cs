using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractEnter : MonoBehaviour
{
    public bool playerIsIn;
    public bool playerHasInteracted;
    public Dialogue d;
    public GameObject dialogueBox;
    public GameObject interactIcon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsIn)
        {
            interactIcon.SetActive(true);
        }
        if(!playerIsIn)
        {
            interactIcon.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && playerIsIn == true && !playerHasInteracted)
        {
            playerHasInteracted = true;
            dialogueBox.SetActive(true);
            d.textComponent.text = string.Empty;
            d.StartDialogue();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsIn = true;
            //playerHasInteracted = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsIn = false;
            playerHasInteracted = false;
        }
    }
}
