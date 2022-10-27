using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    private int bestScore;
    public GameObject bestScoreDisplay;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Best: " + bestScore;
    }
    public void PlayGame()
    {
        buttonPress.Play();
        GlobalScore.currentScore = 0;
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(5);
    }
    public void ResetBest()
    {
        buttonPress.Play();
        PlayerPrefs.SetInt("LevelScore", 0);
        PlayerPrefs.SetInt("LevelScore5", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        bestScoreDisplay.GetComponent<Text>().text = "Best: " + bestScore;
    }
}
