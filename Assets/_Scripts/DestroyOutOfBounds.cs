using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30;
    private float bottomBounds = -10F; 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds || transform.position.z < bottomBounds)
            Destroy(gameObject); 
    }
}
