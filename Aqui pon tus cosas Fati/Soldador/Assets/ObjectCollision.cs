using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{

    CharacterController characterController;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.name == "Cube")
            Debug.Log("I hit the cube!!");
    }
}