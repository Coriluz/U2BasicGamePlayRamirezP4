using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    public GameObject ground;
    private float leftLimit = -30;
    private float bottomLimit = -25;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
       void OnTriggerEnter(Collider other) 
        {
            if (other.gameObject == ground)
            {
                Destroy(gameObject);
            }
        }

    }
}
