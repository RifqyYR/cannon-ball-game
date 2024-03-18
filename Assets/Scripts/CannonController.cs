using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed;
    public float xDegree, yDegree;

    public Transform cannonBody;

    // Update is called once per frame
    void Update()
    {
        CannonMovement();
    }

    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        xDegree += verticalInput * rotationSpeed * Time.deltaTime;
        yDegree += horizontalInput * rotationSpeed * Time.deltaTime;

        yDegree = Mathf.Clamp(yDegree, -30, 30);
        xDegree = Mathf.Clamp(xDegree, -6, 33);

        cannonBody.localEulerAngles = new Vector3(xDegree, 0, yDegree);
    }
}
