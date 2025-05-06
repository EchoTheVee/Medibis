using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ShaderEnabler : MonoBehaviour
{
    //public MeshRenderer mr;
    //public Material noise;
    public GameObject roomCam;
    public GameObject playerCam;
    public GameObject doorCam;
    public CinemachineVirtualCamera vc;
    public PlayerController pc;
    public GameManager gm;
    public mouseaim ma;

    // Start is called before the first frame update
    void Start()
    {
        //noise.GetType("NoiseScale")
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        vc.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vc.gameObject.SetActive(true);
            ma.enabled = false;
            pc.enabled = false;
            doorCam.SetActive(true);
            roomCam.SetActive(false);
            playerCam.SetActive(false);
            vc.Priority = 50;
            roomCam.transform.position = doorCam.transform.position;
            roomCam.transform.rotation = doorCam.transform.rotation;
            gm.doorCutscene();
        }
    }
}
