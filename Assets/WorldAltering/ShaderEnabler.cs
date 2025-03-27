using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderEnabler : MonoBehaviour
{
    public MeshRenderer mr;
    public Material noise;
    
    // Start is called before the first frame update
    void Start()
    {
        //noise.GetType("NoiseScale")
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mr.material = noise;
        }
    }
}
