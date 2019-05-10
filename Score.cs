using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public static int KillCount; // This is our kill count
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        KillCount = 0; // Set kill count to zero every time we start the game.
    }

    void Update()
    {
        text.text = "Zombies Killed: " + KillCount; // Displays the current 
                                                      // number of zomnies 
                                                      // killed.
    }
}
