using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float speed = 0.1f;
    public float senseH = 9.0f;

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * senseH, 0); // Moves camera 
                                                                   // where you point
                                                                   // the mouse.
    }
}
