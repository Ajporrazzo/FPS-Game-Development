using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthUI : MonoBehaviour
{
    public static int health; // value of our health
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        health = 100; // set health to 100 every time game played
    }


    void Update()
    {
        text.text = "Health: " + health; // Adjust the health
    }
}
