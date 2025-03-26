using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    //PROPERTY OF OTTER PRODUCTIONS [DO NOT REMOVE]
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject[] pics;

    private int index;
    //public GameObject pic;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        //StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 0)
        {
            pics[0].SetActive(true);
        }
        else
        {
            pics[0].SetActive(false);
        }

        if (index == 1)
        {
            pics[1].SetActive(true);
        }
        else
        {
            pics[1].SetActive(false);
        }

        if (index == 2)
        {
            pics[2].SetActive(true);
        }
        else
        {
            pics[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                pics[0].SetActive(false);
                pics[1].SetActive(false);
                pics[2].SetActive(false);

                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

        
    }

    public void StartDialogue()
    {
        //gameObject.SetActive(true);
        //pic.gameObject.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            //pic.gameObject.SetActive(true);
        }
    }
}
