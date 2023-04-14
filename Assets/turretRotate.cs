using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretRotate : MonoBehaviour {
    private float turretRotateSpeed = 45f;
    private float turretDirection = 1f;
    
    // Update is called once per frame
    void Update() {
        float turretRotate = Input.GetAxis("Vertical-TT") * turretRotateSpeed * Time.deltaTime;
        transform.Rotate(0, 0, turretRotate);
    }
}
