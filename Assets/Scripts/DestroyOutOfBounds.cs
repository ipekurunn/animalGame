using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -20.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Debug.Log(gameObject.name);
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
