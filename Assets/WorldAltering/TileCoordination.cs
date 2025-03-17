using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCoordination : MonoBehaviour
{
    public MeshRenderer mr;
    public Material on;
    public Material off;

    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            mr.material = on;
        }

        if (!isActive)
        {
            mr.material = off;
        }
    }

    private void OnMouseDown()
    {
        isActive = !isActive;
    }
}
