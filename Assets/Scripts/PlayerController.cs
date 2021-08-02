using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;
    private float xRange = 20.0f;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the player left-to-right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // Move the player up-to-down
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }

        if (transform.position.z > 10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position+projectileSpawnPoint.position, projectilePrefab.transform.rotation); // Launch the projectile from the player
        }
    }
}
