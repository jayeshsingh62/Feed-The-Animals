using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the player left-to-right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

    }
}
