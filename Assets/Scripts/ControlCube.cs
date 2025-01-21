using UnityEngine;

public class ControlCube : MonoBehaviour
{
    float cubeSpeed = 0.002f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * cubeSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * cubeSpeed;
        }
    }
}
