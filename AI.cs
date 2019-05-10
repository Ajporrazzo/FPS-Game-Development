using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour
{
    public float speed = 0.01f;


    void Update()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag("Player"); // AI target

        // Get enemy location
        float tx = targetObject.transform.position.x;
        float ty = targetObject.transform.position.y;
        float tz = targetObject.transform.position.z;

        // Get player location
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        // Location Distance
        float dx = tx - x;
        float dy = ty - y;
        float dz = tz - z;

        // Create new Vector3 based on magnitude of distance in each direction
        Vector3 movement = new Vector3(dx, dy, dz);

        // Normalize the total size of the vector to the desired speed.
        // This insures that the total speed in space is that speed.
        Vector3 movementNormalized = Vector3.ClampMagnitude(movement, speed);

        // Increment the position by the normalized movement
        transform.position += movementNormalized;

        // Create vector for target position (necessary for facing script)
        Vector3 targetVector = new Vector3(tx, ty, tz);

        // Call script to face in direction of target position
        transform.LookAt(targetVector);

    }
}
