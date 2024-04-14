using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public  Rigidbody rb;
    void Start()
    {
        
    }   
    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) *speed);
    }
}
