 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticallInput;
     
     Vector3 moveDirection;

     Rigidbody rb;


     private void start()
     {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
     }


    private void Update()
    {
        MyInput();
    }


     private void MyInput()

     {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticallInput = Input.GetAxisRaw("Vertical");

    }
}


