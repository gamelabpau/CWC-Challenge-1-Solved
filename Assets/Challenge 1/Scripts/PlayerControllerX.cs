using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        // transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
        // transform.Rotate(Vector3.forward * horizontalInput * rotationSpeed * Time.deltaTime);

        Vector3 rotationEulers = (Vector3.right * verticalInput + Vector3.forward * horizontalInput)
                                 * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotationEulers);

    }
}
