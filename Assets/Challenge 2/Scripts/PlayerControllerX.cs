using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 0f;

    // Update is called once per frame
    void Update()
    {
        if (time > 0f)
        {
            // Subtract the difference of the last time the method has been called
            time -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && time <= 0)
        {
            time = 2f;
            Instantiate(dogPrefab, transform.position, transform.rotation);
        }
    }
}
