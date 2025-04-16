using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool atIIU = false;
    public int colorWheel;
    public bool eraserSelected;
    public bool blueSelected;
    public bool redSelected;
    public bool greenSelected;
    public int burnoutNumber;
    public Slider burnoutMeter;
    public float seconds;
    public Camera playerCam;
    public GameObject tab;
    public GameObject cinLight;
    public GameObject cinLight2;
    public GameObject lvlLight;
    public GameObject lvlLight2;
    // Start is called before the first frame update
    void Start()
    {
        burnoutMeter.gameObject.SetActive(false);
        StartCoroutine(uiStart(seconds));
    }

    // Update is called once per frame
    void Update()
    {
        burnoutMeter.value = burnoutNumber;

        if (burnoutNumber > 50)
        {
            burnoutNumber = 50;
        }

        if (burnoutNumber < 0)
        {
            burnoutNumber = 0;
        }

        if (colorWheel == 0)
        {
            eraserSelected = true;
            blueSelected = false;
            redSelected = false;
            greenSelected = false;
        }

        if (colorWheel == 1)
        {
            blueSelected = true;
            greenSelected = false;
            redSelected = false;
            eraserSelected = false;
        }

        if (colorWheel == 2)
        {
            redSelected = true;
            greenSelected = false;
            blueSelected = false;
            eraserSelected = false;
        }

        if (colorWheel == 3)
        {
            greenSelected = true;
            blueSelected = false;
            redSelected = false;
            eraserSelected = false;
        }
    }

    IEnumerator uiStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        playerCam.gameObject.SetActive(true);
        burnoutMeter.gameObject.SetActive(true);
        tab.SetActive(true);
        cinLight.SetActive(false);
        cinLight2.SetActive(false);
        lvlLight.SetActive(true);
        lvlLight2.SetActive(true);
    }
}
