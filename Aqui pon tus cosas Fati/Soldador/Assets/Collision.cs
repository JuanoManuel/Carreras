using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public static int collisions;
    // Start is called before the first frame update
    void Start()
    {
        collisions = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TAGGG: " + other.gameObject.transform.parent.gameObject.name);
        if (other.gameObject.transform.parent.gameObject.name == "Robot")
            collisions++;

        Debug.Log("Lap: " + collisions);

    }
}
