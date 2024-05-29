using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float rotationSpeed = 50.0f;
    private float translationSpeed = 1.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * translationSpeed * Time.deltaTime);
    }
}
