using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderEnabler : MonoBehaviour
{
    //public MeshRenderer mr;
    //public Material noise;
    public GameObject roomCam;
    public GameObject playerCam;
    public GameObject doorCam;
    public PlayerController pc;
    public GameManager gm;
    
    // Start is called before the first frame update
    void Start()
    {
        //noise.GetType("NoiseScale")
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pc.enabled = false;
            roomCam.SetActive(false);
            playerCam.SetActive(false);
            doorCam.SetActive(true);
            roomCam.transform.position = doorCam.transform.position;
            roomCam.transform.rotation = doorCam.transform.rotation;
            gm.doorCutscene();
        }
    }
}
