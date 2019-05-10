using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10.0f;
    private float translation;
    private float straffe;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // turn off the cursor
                                                  // so it is not displayed
                                                  // during the game
    }

    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime; // get user input

        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // move player
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None; // turn on the cursor
        }
    }
}
