using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBullet : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        // I created this script because without it, the bullet objects would
        // destory multiple enemy objests until its lifetime ran up

        if (other.tag == "bullet")
        {
            Destroy(other.gameObject); // Destorys bullet
        }
    }
}
