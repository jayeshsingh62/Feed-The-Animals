using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float horizontalBound = 20;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player's view, destroy that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

        if (transform.position.x > horizontalBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x < -horizontalBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
