using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int damage; // damage value

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            HealthUI.health -= damage; // if their is collison with the player
                                       // decrement the players health
        }

        if(HealthUI.health <= 0)
        {
            Destroy(other.gameObject); // if health <= 0 we destory player
                                       // GAMEOVER!!!!
        }

    }
}
