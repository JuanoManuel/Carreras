using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
    //public static int collisions;
    // Start is called before the first frame update
    void Start()
    {
        //collisions = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnTriggerEnter(Collider other)
    {
        collisions++; 
        Debug.Log("Lap: "+ collisions);
        Debug.Log(other.name + " hit me!! >:p");
    }*/

    void OnCollisionEnter(UnityEngine.Collision c)
    {
       Debug.Log(" enter!!");
    }
}

