using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gm;
    public Rigidbody rb;
    public float moveSpeed;
    public float jumpForce;
    public float horizontalInput;
    public float verticalInput;
    public GameObject cam;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * moveSpeed * verticalInput);
        rb.AddRelativeForce(Vector3.right * moveSpeed * horizontalInput);
    }

    // Update is called once per frame
    void Update()
    {
        //float yRotation = cam.transform.eulerAngles.y;

        Debug.Log($"cam rot y {cam.transform.rotation.y}");
        transform.rotation = Quaternion.Euler(0, cam.transform.localEulerAngles.y, 0);
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gm.atIIU = !gm.atIIU;
        }
    }
}
