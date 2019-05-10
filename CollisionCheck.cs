using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public int ZombieKills = 1; // stating the value of a zombie kill

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject); // Destory object with the tag enemy
            Score.KillCount += ZombieKills; // add zombie death to kill count
        }
    }
}
