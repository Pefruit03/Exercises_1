using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    public static int numberofCoinsG = 0;

    void OnTriggerEnter()
    {
        numberofCoinsG++;
        GlobalScore.currentScore += 500;
        collectSound.Play();
        Destroy(gameObject);
    }
}
