using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {
    private float steerSpeed = 40f;
    private float driveSpeed = 20f;
    private float turretDirection = 1f;

    // Update is called once per frame
    void Update() {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float driveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        /*was confused for realistic movement, but figured if car
        isn't moving, then it can't turn; If-else has been removed to make hitting objects easier*/
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, driveAmount, 0);
    }
    
}
