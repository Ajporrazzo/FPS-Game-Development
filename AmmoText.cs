using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoText : MonoBehaviour
{
    public static int MaxAmmo; // This is our Magazine size
    Text text;


    void Awake()
    {
        text = GetComponent<Text>();
        MaxAmmo = 7; // Set max ammo to 7 every time we start game.
    }


    void Update()
    {
        text.text = "Ammo: " + MaxAmmo; // Displays current ammo amount
    }
}
