using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 7f;

    Rigidbody rb;

    Vector3 move;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // to prevent physics from tipping the object over
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hx = Input.GetAxisRaw("Horizontal");
        float vz = Input.GetAxisRaw("Vertical");
        
        Vector3 input = new Vector3(-hx, 0f, -vz);
        move = input.normalized;
        move = Quaternion.AngleAxis(45, Vector3.up)*move;
    }
    void FixedUpdate()
    {
        Vector3 movementVector = move * MoveSpeed + new Vector3(0f, rb.velocity.y, 0f);
        rb.AddForce(movementVector);
    }
}
