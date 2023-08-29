using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Corrected capitalization here
    public float moveSpeed = 10f;

    private float xInput;
    private float zInput;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Corrected capitalization here

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInput()
    {
        xInput = Input.GetAxis("Horizontal"); // Corrected function name here
        zInput = Input.GetAxis("Vertical"); // Corrected function name here
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
