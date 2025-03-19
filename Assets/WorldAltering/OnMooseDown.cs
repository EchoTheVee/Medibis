using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMooseDown : MonoBehaviour
{
    public GameManager gm;
    public int colorNumber;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gm.colorWheel = colorNumber;
    }
}
