using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    public static int numberofCoinsR = 0;

    void OnTriggerEnter()
    {
        numberofCoinsR++;
        GlobalScore.currentScore += 200;
        collectSound.Play();
        Destroy(gameObject);
    }
}
