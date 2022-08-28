using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10f;
    private float xRange = 10f;
    public GameObject projectile;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // this already has Time.deltaTime applied. 
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        float xModifier = Mathf.Clamp(transform.position.x, -10, 10);

        transform.position = new Vector3(xModifier, 0f, 0f); 

        //if (transform.position.x < -xRange)
        //    transform.position = new Vector3(-10f, transform.position.y, transform.position.z);
        //if (transform.position.x > xRange)
        //    transform.position = new Vector3(10f, transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // give the player as parent if you want the player to move with the projectile. 
            Instantiate(projectile, transform.position, Quaternion.identity);
        }

    }
}
