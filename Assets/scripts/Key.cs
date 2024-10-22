using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour

{

    public bool isKeyHeld = false; 



    void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Player")

        {

            isKeyHeld = true;

            Destroy(gameObject); // Optional: Destroy the key object once picked up

        }

    }

}