using UnityEngine;
using System.Collections;

    public class Shoot : MonoBehaviour
{
    public Rigidbody bullet;
    public int ammo = 7;
    public AudioClip sound;


    void Update()
    {
        if (ammo != 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Rigidbody clone; // This creates a clone of the bullet

                clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(Vector3.forward * 50); // Move bullet in direction



                Destroy(clone.gameObject, 1f); // Destorys the bullet clone after a certain 
                                               // amount of time. 

                ammo--; // decrement ammo each time we shoot
                AmmoText.MaxAmmo--;

            }
        }

        if (Input.GetKeyDown("r"))
        {
            ammo = 7;      // this piece of the code resets 
                           // ammo to 7 when pressed

            AmmoText.MaxAmmo = 7;
        }
    }
}

