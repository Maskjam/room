using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

{

    public bool isLocked = true;



    void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Player" && !isLocked)

        {

            // Open the door animation or logic here

        }

    }



    public void UnlockDoor()

    {

        isLocked = false;

    }

}